using AgeAPP;
using FireSharp.Response;

namespace AgeAPP.Classes
{
    public class FiresharpData
    {
        public class Player
        {
            public string Name { get; set; }
            public int Rating { get; set; }
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            FirebaseResponse response = await FMain.client.GetAsync("players");

            if (response.Body == "null")
                return new List<Player>();

            // Pega a data
            var data = response.ResultAs<Dictionary<string, Player>>();

            return data.Values
                .OrderByDescending(p => p.Rating)
                .ToList();
        }
    }
}
