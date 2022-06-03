using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cBaseLineSeries : ChartSeries
    {
        public CartesianChart catersianchart = new CartesianChart();
        public SeriesCollection seriesCollection;
        public cBaseLineSeries()
        {
            SeriesName = "LineChart";
        }

        public override SeriesCollection createChart()
        {
            seriesCollection = new SeriesCollection()
            {
                new cLineSeries("aaa",new ChartValues<double> {3,4,5,6}),
                new cLineSeries("bbb",new ChartValues<double> {7,8,9,10}),
                new cLineSeries("ccc",new ChartValues<double> {11,12,13,14})
            };
            return seriesCollection;
        }

        public override string getSeriesName()
        {
            return SeriesName;
        }

        public override void Show(DecoratorForm form)
        {
            catersianchart.Series = this.seriesCollection;
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(0, 0);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(984, 486);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            form.elementHost.Child = catersianchart;
            form.Controls.Add(form.elementHost);
        }
    }
}
