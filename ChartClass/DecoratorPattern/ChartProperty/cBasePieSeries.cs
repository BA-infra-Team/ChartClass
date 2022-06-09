using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cBasePieSeries : ChartSeries
    {
        public PieChart piechart = new PieChart();
        public SeriesCollection seriesCollection;
        public cBasePieSeries()
        {
            SeriesName = "PieChart";
        }

        public override SeriesCollection createChart()
        {
            seriesCollection = new SeriesCollection()
            {
                new cPieSeries("aaa",3),
                new cPieSeries("bbb",5),
                new cPieSeries("ccc",6)
            };
            return seriesCollection;
        }

        public override string getSeriesName()
        {
            return SeriesName;
        }

        public override void Show(DecoratorForm form, ChartSeries chart, Panel panel, ElementHost elementHost)
        {
            piechart.Series = chart;
            elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            elementHost.Location = new System.Drawing.Point(0, 0);
            elementHost.Name = "elementHost";
            elementHost.Size = new System.Drawing.Size(984, 486);
            elementHost.TabIndex = 0;
            elementHost.Text = "elementHost";
            elementHost.Child = piechart;
            panel.Controls.Add(elementHost);
        }
    }
}
