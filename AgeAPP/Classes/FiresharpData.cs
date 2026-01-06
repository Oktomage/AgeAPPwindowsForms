using AgeAPP;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Classes
{
    public class FiresharpData
    {
        // Conexão Firesharp
        public static string DataBasePath = "https://ageappv2-default-rtdb.firebaseio.com/";

        public IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = DataBasePath,
            AuthSecret = ""
        };

        public IFirebaseClient client;

        // Admin data
        public bool Admin_LoggedIn = false;
        public Admin Local_Admin_Logged;

        public List<Admin> Admins = new List<Admin>
        {
            new Admin { Name = "pedreiro", Password = "chapeudecouro" },
            new Admin { Name = "gomes", Password = "calvo" },
            new Admin { Name = "oldtime", Password = "artemis" },
            new Admin { Name = "biel", Password = "amointerno" },
            new Admin { Name = "kakashi", Password = "artuzao" },
            new Admin { Name = "snow", Password = "neve" }
        };
        public class Admin
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        // CONNECTION

        public Admin Try_login(string username, string password)
        {
            var admin = Admins.FirstOrDefault(a =>
                a.Name.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                a.Password == password
            );

            if (admin != null)
            {
                Local_Admin_Logged = admin;

                return admin;
            }

            return null;
        }

        public void Connect_to_firesharp(string mode)
        {
            switch (mode.ToLower())
            {
                case "admin":
                    config.AuthSecret = "a1EylzvxpigRZYBKsDl9pLQcRJxiTxpde53z5S4I";
                    Admin_LoggedIn = true;
                    break;

                case "user":
                    Admin_LoggedIn = false;
                    break;
            }

            client = new FireSharp.FirebaseClient(config);

            /*
            if (client != null)
                MessageBox.Show("Connection to database successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        public async Task<AgeApp_settings.Settings> Get_appSettings ()
        {
            FirebaseResponse response = await client.GetAsync("settings");

            if (response.Body == "null")
                return null;

            return response.ResultAs<AgeApp_settings.Settings>();
        }

        public void Download_dataBase_Backup()
        {
            var response = client.GetAsync("").Result;

            string json = response.Body;

            // Formatar JSON
            string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Formatting.Indented);

            string backupFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Backups", $"database_backup_{DateTime.Now:dd-MM-yyyy}.json");

            // Salvar o JSON formatado no arquivo
            File.WriteAllText(backupFilePath, formattedJson);
        }

        // PLAYERS

        public async Task<List<Player>> GetAllPlayers()
        {
            FirebaseResponse response = await client.GetAsync("players");

            if (response.Body == "null")
                return new List<Player>();

            // Pega o conteudo da resposta e converte para dicionario
            var data = response.ResultAs<Dictionary<string, Player>>();

            var players_list = data.Values
                .OrderByDescending(p => p.Rating)
                .Select((p, index) =>
                {
                    p.Id = index + 1;

                    p.WinRate = p.Matches > 0 ? (float)Math.Round((float)p.Wins / p.Matches * 100, 2) : 0;

                    return p;
                })
                .ToList();

            return players_list;
        }

        public async Task<Player> Get_player(string player_name)
        {
            FirebaseResponse response = await client.GetAsync($"players/{player_name}");

            var player = response.ResultAs<Player>();
            return player;
        }

        public async Task Overwrite_player(Player player)
        {
            await client.SetAsync($"players/{player.Name}", player);
        }

        public async Task Overwrite_playerData(Player player, string field, object new_value)
        {
            var data = new Dictionary<string, object>
            {
                { field, new_value }
            };

            await client.UpdateAsync($"players/{player.Name}", data);
        }

        public async Task Add_new_player(Player player)
        {
            await client.SetAsync($"players/{player.Name.ToLower()}", player);
        }

        public async Task Delete_player(Player player)
        {
            await client.DeleteAsync($"players/{player.Name}");
        }

        // MAPS

        public async Task<List<Map>> GetAllMaps()
        {
            FirebaseResponse response = await client.GetAsync("maps");
            
            var data = response.ResultAs<Dictionary<string, Map>>();

            var maps_list = data.Values.ToList();

            return maps_list;
        }

        public async Task<Map> Get_map(string map_name)
        {
            FirebaseResponse response = await client.GetAsync($"maps/{map_name}");

            var map = response.ResultAs<Map>();
            return map;
        }

        public async Task Add_new_map(Map map)
        {
            await client.SetAsync($"maps/{map.Name.ToLower()}", map);
        }

        public async Task Overwrite_map(Map map)
        {
            await client.SetAsync($"maps/{map.Name}", map);
        }

        public async Task Delete_map(Map map)
        {
            await client.DeleteAsync($"maps/{map.Name}");
        }

        // LOGS

        public async Task Post_log_on_dataBase(Log log)
        {
            await client.PushAsync($"logs/{log.Author_name}/{log.Role}", log);
        }

        public async Task<List<Log>> GetMatchHistory(string admin)
        {
            var response = await client.GetAsync($"logs/{admin}/Match_results");

            if (response.Body == "null")
                return new List<Log>();

            var data = JsonConvert.DeserializeObject<Dictionary<string, Log>>(response.Body);

            return data.Values
                       .OrderByDescending(x => x.Match_result.MatchDate)
                       .ToList();
        }
    }
}
