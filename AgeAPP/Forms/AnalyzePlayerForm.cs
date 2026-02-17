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
            ApplyDarkTheme();
            LoadPlayerData();
        }

        private void ApplyDarkTheme()
        {
            FormChartPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#0f172a");

            FormChartPlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#0f172a");

            FormChartPlot.Plot.Axes.Color(ScottPlot.Color.FromHex("#9ca3af"));

            FormChartPlot.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#1e293b");
        }

        private void LoadChart(List<RatingHistory> history)
        {
            if (history == null || history.Count == 0)
                return;

            double[] xs = history
                .Select(x => x.Date.ToOADate())
                .ToArray();

            double[] ys = history
                .Select(x => (double)x.Rating)
                .ToArray();

            FormChartPlot.Plot.Clear();

            var line = FormChartPlot.Plot.Add.ScatterLine(xs, ys);

            line.Color = ScottPlot.Color.FromHex("#f59e0b");
            line.LineWidth = 2;
            line.MarkerSize = 6;
            line.MarkerShape = ScottPlot.MarkerShape.FilledCircle;
            line.MarkerFillColor = ScottPlot.Color.FromHex("#f59e0b");

            // eixo de tempo real
            FormChartPlot.Plot.Axes.DateTimeTicksBottom();

            FormChartPlot.Plot.Axes.Bottom.TickGenerator =
            new ScottPlot.TickGenerators.DateTimeAutomatic
            {
                LabelFormatter = dt => dt.ToString("dd/MM")
            };

            FormChartPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0;

            // Corrige as cores
            FormChartPlot.Plot.Axes.Bottom.TickLabelStyle.ForeColor = ScottPlot.Color.FromHex("#ffffff");
            FormChartPlot.Plot.Axes.Left.TickLabelStyle.ForeColor = ScottPlot.Color.FromHex("#ffffff");

            FormChartPlot.Plot.Axes.AutoScale();

            FormChartPlot.Refresh();
        }

        private async void LoadPlayerData()
        {
            LoadingLabel.Visible = true;
            PlayerNameLabel.Text = $"| Jogador: ({CurrentPlayer.Name})";

            FormChartPlot.UserInputProcessor.IsEnabled = false;

            var history = await local_Data_service.BuildPlayerRatingHistory(CurrentPlayer.Name);

            LoadChart(history);

            LoadingLabel.Visible = false;
        }
    }
}
