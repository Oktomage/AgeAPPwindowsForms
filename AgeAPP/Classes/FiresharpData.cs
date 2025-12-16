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
        public Admin Admin_Logged;

        public List<Admin> Admins = new List<Admin>
        {
            new Admin { Name = "pedreiro", Password = "admin123" },
            new Admin { Name = "oldtime", Password = "admin123" },
            new Admin { Name = "biel", Password = "admin123" },
            new Admin { Name = "kakashi", Password = "admin123" },
            new Admin { Name = "snow", Password = "admin123" }
        };

        public class Admin
        {
            public string Name { get; set; }
            public string Password { get; set; }
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
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            FirebaseResponse response = await client.GetAsync("players");

            if (response.Body == "null")
                return new List<Player>();

            // Pega a data
            var data = response.ResultAs<Dictionary<string, Player>>();

            return data.Values
                .OrderByDescending(p => p.Rating)
                .Select((p, index) =>
                {
                    p.Id = index + 1;
                    return p;
                })
                .ToList();
        }
    }
}
