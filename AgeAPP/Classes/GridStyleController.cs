using System.Globalization;

namespace AgeAPP.Classes
{
    internal class GridStyleController
    {
        public static void FixPlayersHeaderNames(DataGridView grid)
        {
            RenameColumn(grid, "Id", "Posição");
            RenameColumn(grid, "Name", "Nome");
            RenameColumn(grid, "Matches", "Partidas");
            RenameColumn(grid, "Wins", "Vitórias");
            RenameColumn(grid, "WinRate", "%");
        }

        private static void RenameColumn(DataGridView grid, string columnName, string headerText)
        {
            if (grid.Columns.Contains(columnName))
            {
                grid.Columns[columnName].HeaderText = headerText;
            }
        }

        public static void ApplyWinRateColoring(DataGridView grid, string winRateColumnName = "WinRate")
        {
            grid.CellFormatting += (s, e) =>
            {
                if (grid.Columns[e.ColumnIndex].Name != winRateColumnName || e.Value == null)
                    return;

                if (!double.TryParse(
                        e.Value.ToString(),
                        NumberStyles.Any,
                        CultureInfo.CurrentCulture,
                        out double winRate))
                    return;

                if (winRate < 50)
                    e.CellStyle.ForeColor = Color.Red;
                else if (winRate == 50)
                    e.CellStyle.ForeColor = Color.Goldenrod;
                else
                    e.CellStyle.ForeColor = Color.Green;
            };
        }
    }
}
