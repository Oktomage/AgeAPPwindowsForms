using System.ComponentModel;

namespace AgeAPP.Classes
{
    public class Main_classes
    {
        public string App_Version = "5.4.0";
        public static bool Show_only_active_players = false;

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

        public class MatchResult
        {
            public List<Player> TeamA { get; set; } = new List<Player>();
            public List<Player> TeamB { get; set; } = new List<Player>();
            public int DeltaRating { get; set; }
            public bool TeamAWon { get; set; }
            public string PlayedMap_name { get; set; }
            public DateTime MatchDate { get; set; }
        }
    }
}
