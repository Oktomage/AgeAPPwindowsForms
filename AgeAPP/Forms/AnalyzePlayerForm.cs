using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class AnalyzePlayerForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service;

        // Local data
        private Main_classes.Player CurrentPlayer;

        public AnalyzePlayerForm(Main_classes.Player Player)
        {
            InitializeComponent();

            local_Data_service = FMain.Data_service;
            CurrentPlayer = Player;
        }

        private void AnalyzePlayerForm_Load(object sender, EventArgs e)
        {
            LoadRatingChart();
            LoadPlayerData();
        }

        private void ApplyDarkTheme()
        {
            FormChartPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#0f172a");

            FormChartPlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#0f172a");

            FormChartPlot.Plot.Axes.Color(ScottPlot.Color.FromHex("#9ca3af"));

            FormChartPlot.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#1e293b");
        }

        private void LoadRatingChart()
        {
            // exemplo (substitua pelos dados do seu Firebase)
            double[] ratings = { 1000, 1200, 1400, 1350, 1500, 1650, 1600, 1750, 1800 };

            double[] xs = Enumerable.Range(0, ratings.Length)
                .Select(x => (double)x)
                .ToArray();

            FormChartPlot.Plot.Clear();

            var line = FormChartPlot.Plot.Add.Scatter(xs, ratings);

            // cor laranja igual ao gráfico que você mostrou
            line.Color = ScottPlot.Color.FromHex("#f59e0b");

            line.LineWidth = 2;

            ApplyDarkTheme();

            FormChartPlot.Refresh();
        }

        private async void LoadPlayerData()
        {
            PlayerNameLabel.Text = CurrentPlayer.Name;

            var history = await Data_service.GetPlayerRatingHistory(_player.Name);

            LoadChart(history);
        }
    }
}
