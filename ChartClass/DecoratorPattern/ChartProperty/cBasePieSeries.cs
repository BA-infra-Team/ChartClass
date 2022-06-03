using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override void Show(DecoratorForm form)
        {
            piechart.Series = this.seriesCollection;
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(0, 0);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(984, 486);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            form.elementHost.Child = piechart;
            form.Controls.Add(form.elementHost);
        }
    }
}
