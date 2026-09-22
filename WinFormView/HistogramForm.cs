using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormView
{
    public partial class HistogramForm : Form
    {
        private readonly Logic logic;
        public HistogramForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            panelHistogram.Paint += PanelHistogram_Paint;
        }
        private void PanelHistogram_Paint(object? sender, PaintEventArgs e)
        {
            var histogram = logic.Histogram();

            if (histogram.Count == 0)
            {
                e.Graphics.DrawString(
                    "Нет данных",
                    Font,
                    Brushes.Black,
                    20,
                    20);

                return;
            }

            int x = 20;
            int y = 30;

            foreach (var item in histogram)
            {
                string group = item.Key;
                int count = item.Value;

                e.Graphics.DrawString(
                    group,
                    Font,
                    Brushes.Black,
                    x,
                    y);

                int barWidth = count * 30;

                e.Graphics.FillRectangle(
                    Brushes.SteelBlue,
                    x + 100,
                    y,
                    barWidth,
                    20);

                e.Graphics.DrawString(
                    count.ToString(),
                    Font,
                    Brushes.Black,
                    x + 110 + barWidth,
                    y);

                y += 40;
            }
        }
    }
}
