using AgeAPP.Properties;
using System.Collections;
using System.Globalization;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

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

        public bool Check_for_updates()
        {
            string onlineVersion = FMain.AgeApp_settings_service.Lastest_appVersion.Trim();
            string localVersion = Local_app_Version;

            Version vOnline = new Version(onlineVersion);
            Version vLocal = new Version(localVersion);

            return vOnline > vLocal;
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

        public Map Get_mapBased_on_players_favoriteMaps(List<Player> players, List<Map> allMaps)
        {
            // Dicionário: mapa -> peso
            Dictionary<string, int> votes = new Dictionary<string, int>();

            // Inicializa todos os mapas com peso 0
            foreach (var map in allMaps)
            {
                votes[map.Name] = 0;
            }

            // Conta votos
            foreach (var player in players)
            {
                if (player.Favorite_maps == null)
                    continue;

                foreach (var favMap in player.Favorite_maps.Keys)
                {
                    if (votes.ContainsKey(favMap))
                    {
                        votes[favMap]++;
                    }
                }
            }

            // Remove mapas sem votos (opcional)
            var validVotes = votes
                .Where(v => v.Value > 0)
                .ToList();

            // Se ninguém votou, escolhe aleatório
            if (!validVotes.Any())
            {
                return allMaps[new Random().Next(allMaps.Count)];
            }

            // Sorteio ponderado
            int totalWeight = validVotes.Sum(v => v.Value);
            int roll = new Random().Next(1, totalWeight + 1);

            int cumulative = 0;
            foreach (var v in validVotes)
            {
                cumulative += v.Value;
                if (roll <= cumulative)
                {
                    return allMaps.First(m => m.Name == v.Key);
                }
            }

            // Fallback (não deveria acontecer)
            return allMaps.First();
        }

        #endregion

        #region Match results Methods 

        public MatchResult Get_match_result(List<Player> teamA, List<Player> teamB, bool teamAWon, string map_name)
        {
            MatchResult result = new MatchResult();

            result.TeamAWon = teamAWon;
            result.MatchDate = DateTime.Now;
            result.PlayedMap_name = map_name;

            int teamARating = teamA.Sum(p => p.Rating);
            int teamBRating = teamB.Sum(p => p.Rating);

            // Calcula valor da mudança de rating
            int ratingDelta = Calculate_rating_changes(teamARating, teamBRating, teamAWon);

            result.DeltaRating = ratingDelta;

            // Aplica mudanças nos jogadores
            foreach (var player in teamA)
            {
                result.TeamA.Add(player);

                player.Matches += 1;

                if (teamAWon)
                {
                    player.Wins += 1;
                }

                // Aplica mudança de dados
                player.Rating += ratingDelta;
                player.Last_time_played = DateTime.Now.ToString("g");
            }
            foreach (var player in teamB)
            {
                result.TeamB.Add(player);

                player.Matches += 1;

                if (!teamAWon)
                {
                    player.Wins += 1;
                }

                // Aplica mudança de dados
                player.Rating -= ratingDelta;
                player.Last_time_played = DateTime.Now.ToString("g");
            }

            List<Player> all_updated_players = teamA.Concat(teamB).ToList();

            return result;
        }

        public int Calculate_expected_rating_changes(int teamRatingA, int teamRatingB)
        {
            int K_FACTOR = FMain.AgeApp_settings_service.Kfactor;
            int diff = teamRatingA - teamRatingB;

            // vantagem esperada
            float expectedA = 1f / (1f + (float)Math.Pow(10, -diff / 400f));

            // valor esperado de mudança de rating
            int expectedDeltaA = (int)Math.Round(K_FACTOR * (1f - expectedA));

            return expectedDeltaA;
        }

        private int Calculate_rating_changes(int teamRatingA, int teamRatingB, bool teamAWon)
        {
            int K_FACTOR = FMain.AgeApp_settings_service.Kfactor;

            int diff = teamRatingA - teamRatingB;

            // vantagem esperada
            float expectedA = 1f / (1f + (float)Math.Pow(10, -diff / 400f));

            float scoreA = teamAWon ? 1f : 0f;

            int deltaA = (int)Math.Round(K_FACTOR * (scoreA - expectedA));

            return deltaA;
        }

        #endregion

        #region Log Methods

        public void Save_log_to_file(Log log)
        {
            string logFileName = $"log_ {log.Role}_{DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss")}.json";
            string logFilePath = Path.Combine(LogsFolder_path, logFileName);

            // Serializa log para JSON identado
            string json = System.Text.Json.JsonSerializer.Serialize(log, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(logFilePath, json);
        }

        #endregion

        #region Avatars

        private static Dictionary<string, Image> AvatarCache;

        private static void EnsureAvatarCache()
        {
            if (AvatarCache != null)
                return;

            AvatarCache = new Dictionary<string, Image>();

            var resources = Properties.Resources.ResourceManager.GetResourceSet(
                CultureInfo.CurrentCulture,
                true,
                true
            );

            foreach (DictionaryEntry entry in resources)
            {
                if (entry.Value is Image image)
                {
                    string key = entry.Key.ToString();
                    AvatarCache[key] = image;
                }
            }
        }

        public static void LoadAvatarsOnLayoutPanel(FlowLayoutPanel panel, Action<PictureBox> onAvatarClick)
        {
            EnsureAvatarCache();

            panel.Controls.Clear();

            var resources = Properties.Resources.ResourceManager.GetResourceSet(
                CultureInfo.CurrentCulture,
                true,
                true
            );

            foreach (var kv in AvatarCache)
            {
                string resourceName = kv.Key;
                Image image = kv.Value;

                // 🔹 Filtro por padrão
                if (!resourceName.StartsWith("Player_icon"))
                    continue;

                var pic = new PictureBox
                {
                    Width = 64,
                    Height = 64,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = image,
                    Cursor = Cursors.Hand,
                    Tag = resourceName,
                    Margin = new Padding(8),
                    BorderStyle = BorderStyle.FixedSingle
                };

                //  Evento desacoplado
                pic.Click += (s, e) => onAvatarClick((PictureBox)s);

                panel.Controls.Add(pic);
            }
        }

        public static Image LoadAvatar(string avatarId)
        {
            EnsureAvatarCache();

            if (string.IsNullOrWhiteSpace(avatarId))
                return Properties.Resources.Player_icon1;

            return AvatarCache.TryGetValue(avatarId, out var image)
                ? image
                : Properties.Resources.Player_icon1;
        }

        #endregion
    }
}
