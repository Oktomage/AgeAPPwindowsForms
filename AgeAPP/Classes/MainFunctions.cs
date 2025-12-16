using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Classes
{
    public class MainFunctions
    {
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
    }
}
