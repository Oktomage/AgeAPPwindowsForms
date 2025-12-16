using AgeAPP;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

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
            switch(mode.ToLower())
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

        public class Player
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Rating { get; set; }
            public int Matches { get; set; }
            public int Wins { get; set; }
            public float WinRate { get; set; }
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
    }
}
