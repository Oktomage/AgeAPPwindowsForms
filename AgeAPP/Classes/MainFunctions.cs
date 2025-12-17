using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Classes
{
    public class MainFunctions
    {
        public static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        public string DataFolder_path { get; set; } = Path.Combine(basePath, "Data");
        public string LogsFolder_path { get; set; } = Path.Combine(basePath, "Data", "Logs");
        public string BackupsFolder_path { get; set; } = Path.Combine(basePath, "Data", "Backups");

        public void Create_Required_folders()
        {
            if(Directory.Exists(DataFolder_path))
                return;

            Directory.CreateDirectory(DataFolder_path);
            Directory.CreateDirectory(LogsFolder_path);
            Directory.CreateDirectory(BackupsFolder_path);
        }

        class SessionData
        {
            public Admin Local_admin { get; set; }
        }
        public void Save_session(Admin local_admin)
        {
            SessionData session = new SessionData
            {
                Local_admin = local_admin
            };

            string json = System.Text.Json.JsonSerializer.Serialize(session);

            File.WriteAllText(Path.Combine(DataFolder_path, "session.json"), json);
        }

        public Admin Load_session()
        {
            string sessionFilePath = Path.Combine(DataFolder_path, "session.json");

            if (!File.Exists(sessionFilePath))
                return null;

            string json = File.ReadAllText(sessionFilePath);

            SessionData session = System.Text.Json.JsonSerializer.Deserialize<SessionData>(json);

            return session.Local_admin;
        }

        public void Delete_session()
        {
            string sessionFilePath = Path.Combine(DataFolder_path, "session.json");

            if (File.Exists(sessionFilePath))
                File.Delete(sessionFilePath);
        }

        #region Team Splitting Methods

        public (List<Player> teamA, List<Player> teamB) SplitTeams(List<Player> players)
        {
            var teamA = new List<Player>();
            var teamB = new List<Player>();

            int ratingA = 0;
            int ratingB = 0;

            foreach (var p in players.OrderByDescending(p => p.Rating))
            {
                if (ratingA <= ratingB)
                {
                    teamA.Add(p);
                    ratingA += p.Rating;
                }
                else
                {
                    teamB.Add(p);
                    ratingB += p.Rating;
                }
            }

            return (teamA, teamB);
        }

        public (List<Player> teamA, List<Player> teamB) SplitTeamsBruteForce(List<Player> players)
        {
            int n = players.Count;

            if (n % 2 != 0)
                throw new Exception("Número de jogadores deve ser par.");

            int teamSize = n / 2;

            List<Player> bestTeamA = null;
            List<Player> bestTeamB = null;
            int minDifference = int.MaxValue;

            int totalCombinations = 1 << n; // 2^n

            for (int mask = 0; mask < totalCombinations; mask++)
            {
                var teamA = new List<Player>();
                var teamB = new List<Player>();

                for (int i = 0; i < n; i++)
                {
                    if ((mask & (1 << i)) != 0)
                        teamA.Add(players[i]);
                    else
                        teamB.Add(players[i]);
                }

                // Garante times do mesmo tamanho
                if (teamA.Count != teamSize)
                    continue;

                int ratingA = teamA.Sum(p => p.Rating);
                int ratingB = teamB.Sum(p => p.Rating);

                int diff = Math.Abs(ratingA - ratingB);

                if (diff < minDifference)
                {
                    minDifference = diff;
                    bestTeamA = teamA;
                    bestTeamB = teamB;

                    // Diferença perfeita → não tem como melhorar
                    if (diff == 0)
                        break;
                }
            }

            return (bestTeamA, bestTeamB);
        }

        #endregion

        #region Match results Methods 

        public List<Player> Apply_match_result(List<Player> teamA, List<Player> teamB, bool teamAWon)
        {
            int teamARating = teamA.Sum(p => p.Rating);
            int teamBRating = teamB.Sum(p => p.Rating);

            // Calcula valor da mudança de rating
            int ratingDelta = Calculate_rating_delta_changes(teamARating, teamBRating, teamAWon);

            // Aplica mudanças nos jogadores
            foreach (var player in teamA)
            {
                player.Matches += 1;

                if (teamAWon)
                {
                    player.Wins += 1;
                }

                player.Rating += ratingDelta;
            }
            foreach (var player in teamB)
            {
                player.Matches += 1;

                if (!teamAWon)
                {
                    player.Wins += 1;
                }

                player.Rating -= ratingDelta;  
            }

            List<Player> all_updated_players = teamA.Concat(teamB).ToList();

            /*
            string message = string.Join(
                Environment.NewLine,
                all_updated_players.Select(p =>
                $"{p.Name} | Rating: {p.Rating} | Wins: {p.Wins} | Matches: {p.Matches}")
                );

            MessageBox.Show($"{message}");
            */

            return all_updated_players;
        }

        private int Calculate_rating_delta_changes(int teamRatingA, int teamRatingB, bool teamAWon)
        {
             int BASE_DELTA = 20;

            int diff = teamRatingA - teamRatingB;

            // vantagem esperada
            float expectedA = 1f / (1f + (float)Math.Pow(10, -diff / 400f));

            float scoreA = teamAWon ? 1f : 0f;

            int deltaA = (int)Math.Round(BASE_DELTA * (scoreA - expectedA));

            return deltaA;
        }

        #endregion
    }
}
