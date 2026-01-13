using AgeAPP.Properties;
using System.Collections;
using System.Globalization;
using System.Reflection;
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
            MatchResult result = new MatchResult
            {
                TeamAWon = teamAWon,
                MatchDate = DateTime.Now,
                PlayedMap_name = map_name
            };

            int teamARating = teamA.Sum(p => p.Rating);
            int teamBRating = teamB.Sum(p => p.Rating);

            // 🔹 Delta do Time A
            int deltaTeamA = Calculate_rating_changes(
                teamARating,
                teamBRating,
                teamAWon
            );

            int deltaTeamB = -deltaTeamA;

            result.DeltaRating = Math.Abs(deltaTeamA);

            // 🔹 Aplica no Time A
            foreach (var player in teamA)
            {
                result.TeamA.Add(player);

                player.Matches += 1;
                if (teamAWon)
                    player.Wins += 1;

                player.Rating += deltaTeamA;
                player.Last_time_played = DateTime.Now.ToString("g");
            }

            // 🔹 Aplica no Time B
            foreach (var player in teamB)
            {
                result.TeamB.Add(player);

                player.Matches += 1;
                if (!teamAWon)
                    player.Wins += 1;

                player.Rating += deltaTeamB;
                player.Last_time_played = DateTime.Now.ToString("g");
            }

            return result;
        }

        /*
        public Dictionary<string, int> CalculatePreviewIndividualChanges(List<Player> teamA, List<Player> teamB, bool teamAWon)
        {
            var preview = new Dictionary<string, int>();

            if (teamA.Count == 0 || teamB.Count == 0)
                return preview;

            int avgRatingA = (int)teamA.Average(p => p.Rating);
            int avgRatingB = (int)teamB.Average(p => p.Rating);

            // 🔹 Preview Time A
            foreach (var player in teamA)
            {
                int delta = CalculateIndividualDelta(
                    player.Rating,
                    avgRatingB,
                    teamAWon
                );

                preview[player.Name] = delta;
            }

            // 🔹 Preview Time B
            foreach (var player in teamB)
            {
                int delta = CalculateIndividualDelta(
                    player.Rating,
                    avgRatingA,
                    !teamAWon
                );

                preview[player.Name] = delta;
            }

            return preview;
        }

        private int CalculateIndividualDelta(int playerRating, int opponentAvgRating, bool playerWon)
        {
            int K = FMain.AgeApp_settings_service.Kfactor;

            float expected = 1f / (1f + (float)Math.Pow(10, (opponentAvgRating - playerRating) / 400f));

            float score = playerWon ? 1f : 0f;

            return (int)Math.Round(K * (score - expected));
        }
        */
        
        public int Calculate_rating_changes(int teamRatingA, int teamRatingB, bool teamAWon)
        {
            int Kfactor = FMain.AgeApp_settings_service.Kfactor;

            int diff = teamRatingA - teamRatingB;

            float expectedA = 1f / (1f + (float)Math.Pow(10, -diff / 400f));
            float scoreA = teamAWon ? 1f : 0f;

            double diffFactor = Math.Clamp(
                Math.Abs(diff) / 400.0,
                1.0,
                2.5
            );

            int deltaA = (int)Math.Round(
                Kfactor * diffFactor * (scoreA - expectedA)
            );

            return deltaA;
        }

        /*
        private Dictionary<string, int> CalculateIndividualRatingChanges(List<Player> team, int teamDelta)
        {
            var result = new Dictionary<string, int>();

            if (team.Count == 0 || teamDelta == 0)
                return result;

            double avgRating = team.Average(p => p.Rating);

            var weights = team.ToDictionary(
                p => p.Name,
                p => p.Rating / avgRating
            );

            double totalWeight = weights.Values.Sum();

            int distributed = 0;

            foreach (var kv in weights)
            {
                int delta = (int)Math.Round(teamDelta * (kv.Value / totalWeight));
                result[kv.Key] = delta;
                distributed += delta;
            }

            // Ajuste de arredondamento
            int diff = teamDelta - distributed;
            if (diff != 0)
            {
                string adjustPlayer = team
                    .OrderBy(p => p.Rating)
                    .First()
                    .Name;

                result[adjustPlayer] += diff;
            }

            return result;
        }
        */
        
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

        #region Maps

        public static class MapImageDictionary
        {
            private static readonly Dictionary<string, Image> _mapImages =
                new(StringComparer.OrdinalIgnoreCase)
                {
                // === RM ===
                { "arabia", Properties.Resources.rm_arabia },
                { "atacama", Properties.Resources.rm_atacama },
                { "floresta negra", Properties.Resources.rm_black_forest },
                { "clareira africana", Properties.Resources.rm_african_clearing },
                { "ilhas de equipe", Properties.Resources.rm_team_islands },
                { "megarandom", Properties.Resources.rm_megarandom },
                { "acropole", Properties.Resources.rm_acropolis },
                { "reclusao", Properties.Resources.rm_enclosed },
                { "esconderijo", Properties.Resources.rm_hideout },
                { "pedras runicas", Properties.Resources.rm_qs_runestones },
                { "estepe", Properties.Resources.rm_steppe },
                { "nomade de terra", Properties.Resources.rm_land_nomad },
                { "haboob", Properties.Resources.rm_haboob },
                { "terras altas", Properties.Resources.rm_highland },
                { "hamburguer", Properties.Resources.rm_hamburger },
                { "arena", Properties.Resources.rm_arena },
                { "clareira", Properties.Resources.rm_glade },
                { "nomade", Properties.Resources.rm_nomad },
                { "buraco do ouro", Properties.Resources.rm_golden_pit},
                { "lombardia", Properties.Resources.rm_lombardia },
                { "quatro lagos", Properties.Resources.rm_four_lakes },
                { "lago gelido", Properties.Resources.rm_frigid_lake },
                { "michi", Properties.Resources.rm_michi },
                { "baltico", Properties.Resources.rm_baltic },
                { "migraçao", Properties.Resources.rm_migration },
                { "febre do ouro", Properties.Resources.rm_gold_rush },
                { "ilhas", Properties.Resources.rm_islands },
                { "oasis", Properties.Resources.rm_oasis },
                { "fortaleza", Properties.Resources.rm_fortress },
                { "unknown", Properties.Resources.UnkownMap },
                };

            public static Image Get(string mapName)
            {
                if (string.IsNullOrWhiteSpace(mapName))
                    return Properties.Resources.UnkownMap;

                if (_mapImages.TryGetValue(mapName.Trim(), out var image))
                    return image;

                return Properties.Resources.UnkownMap;
            }
        }

        #endregion
    }
}
