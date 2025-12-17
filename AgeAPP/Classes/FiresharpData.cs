using AgeAPP;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace AgeAPP.Classes
{
    public class FiresharpData
    {
        // Firesharp connection
        public IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://internoapp-e8138-default-rtdb.firebaseio.com/",
            AuthSecret = ""
        };

        public IFirebaseClient client;

        // Admin
        public bool Admin_LoggedIn = false;
        public Admin Local_Admin_Logged;

        public List<Admin> Admins = new List<Admin>
        {
            new Admin { Name = "pedreiro", Password = "chapeudecouro" },
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
                    config.AuthSecret = "wG6kd0l3gfUtBDqu4g1xqXPpm4gl5tMsXTLqIl99";
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

        public void Download_dataBase_Backup()
        {
            var response = client.GetAsync("").Result;

            string json = response.Body;

            // Formatar JSON
            string formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Formatting.Indented);

            string backupFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Backups", $"database_backup_{DateTime.Now:yyyyMMdd_HHmmss}.json");

            // Salvar o JSON formatado no arquivo
            File.WriteAllText(backupFilePath, formattedJson);
        }

        public class Map
        {
            public string Name { get; set; }
            public int Type { get; set; }
        }

        public class Player
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Rating { get; set; }
            public int Matches { get; set; }
            public int Wins { get; set; }
            public float WinRate { get; set; }
            //public List<Map> Favorite_maps { get; set; }
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

        public class Log
        {
            public string Author_name;
            public string Date;
            public List<Player> Players = new List<Player>();

            public string Role = "default";
            public string Content;
        }
        public async Task Post_log(Log log)
        {
            await client.PushAsync($"logs/{log.Author_name}/{log.Role}", log);
        }
    }
}
