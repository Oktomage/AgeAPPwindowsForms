using System.Globalization;

namespace AgeAPP.Classes
{
    internal class GridStyleController
    {
        public enum GridTheme
        {
            Light,
            Dark
        }

        public static GridTheme CurrentTheme { get; private set; } = GridTheme.Light;

        public static void ToggleTheme()
        {
            CurrentTheme = CurrentTheme == GridTheme.Light ? GridTheme.Dark : GridTheme.Light;
        }

        public static void ApplyTheme(DataGridView grid)
        {
            if (CurrentTheme == GridTheme.Dark)
                ApplyDark(grid);
            else
                ApplyLight(grid);
        }

        private static void ApplyDark(DataGridView grid)
        {
            grid.BackgroundColor = Color.FromArgb(18, 18, 18);
            grid.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grid.GridColor = Color.FromArgb(50, 50, 50);
            grid.EnableHeadersVisualStyles = false;
        }

        private static void ApplyLight(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grid.GridColor = Color.LightGray;
            grid.EnableHeadersVisualStyles = false;
        }

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
