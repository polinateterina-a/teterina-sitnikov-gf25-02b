using BusinessLogic;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormView
{
    public partial class HistogramForm : Form
    {
        public HistogramForm(Logic logic)
        {
            Text = "Гистограмма";
            ClientSize = new Size(600, 380);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var histogram = logic.Histogram();

            var chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            var area = new ChartArea("Main");
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;     
            area.AxisX.MajorTickMark.Enabled = false; 

            area.AxisY.Minimum = 0;
            area.AxisY.Interval = 1;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisY.Title = "Количество студентов";
            chart.ChartAreas.Add(area);

            if (histogram.Count == 0)
            {
                chart.Titles.Add("Нет данных");
            }
            else
            {
                chart.Titles.Add("Распределение студентов");

                var series = new Series("Студенты")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.SteelBlue,
                    IsValueShownAsLabel = true
                };
                series["PointWidth"] = "0.3";

                foreach (var item in histogram)
                {
                    series.Points.AddXY(item.Key, item.Value);
                }

                chart.Series.Add(series);
            }

            Controls.Add(chart);
        }
    }
}