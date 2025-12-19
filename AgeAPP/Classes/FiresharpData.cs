using AgeAPP;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.ComponentModel;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.MainFunctions;

namespace AgeAPP.Classes
{
    public class FiresharpData
    {
        // Serviços
        private Main_classes local_Main_classes = new Main_classes();

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

        public async Task<bool> Check_for_updates()
        {
            FirebaseResponse response = await client.GetAsync($"/version");

            if (response.Body == "null")
                return false;

            string onlineVersion = response.ResultAs<string>().Trim();
            string localVersion = local_Main_classes.App_Version;

            Version vOnline = new Version(onlineVersion);
            Version vLocal = new Version(localVersion);

            return vOnline > vLocal;
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

        public class Player
        {
            public int Id { get; set; } = 0;
            public string Name { get; set; } = "system_error";
            public int Rating { get; set; } = 0;
            public int Matches { get; set; } = 0;
            public int Wins { get; set; } = 0;
            public float WinRate { get; set; }

            [Browsable(false)]
            public string Last_time_played { get; set; }

            [Browsable(false)]
            public Dictionary<string, FavoriteMap> Favorite_maps { get; set; } = new Dictionary<string, FavoriteMap>();
        }

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

        public class FavoriteMap
        {
            public string Name { get; set; }
            public int Times_played { get; set; }
        }
        public class Map
        {
            public string Name { get; set; }
            public int Matches { get; set; }
            public int Type { get; set; }
        }
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

        public class Log
        {
            public string Author_name { get; set; }
            public string Date { get; set; }
            public List<Player> All_players { get; set; } = new List<Player>();
            public List<Player> TeamA_players { get; set; } = new List<Player>();
            public List<Player> TeamB_players { get; set; } = new List<Player>();
            public int Expected_rating_changes { get; set; }
            public Map Played_map { get; set; }
            public string Role { get; set; } = "default";
            public string Content { get; set; }
            public MatchResult Match_result { get; set; }
        }
        public async Task Post_log_on_dataBase(Log log)
        {
            await client.PushAsync($"logs/{log.Author_name}/{log.Role}", log);
        }
    }
}
