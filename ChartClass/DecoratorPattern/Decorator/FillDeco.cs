using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChartClass.DecoratorPattern.Decorator
{
    public class FillDeco : ChartDecorator
    {
        ChartSeries chartseries;

        private SolidColorBrush brush = null;
        public PieChart piechart = new PieChart();
        public CartesianChart catersianchart = new CartesianChart();

        public SeriesCollection seriescollection;
        public FillDeco(ChartSeries chartseries)
        {
            this.chartseries = chartseries;
        }
        public override SeriesCollection createChart()
        {
            if (chartseries.getSeriesName() != null)
            {
                if(chartseries.getSeriesName() == "PieChart")
                {
                    seriescollection = chartseries.createChart();
                    brush = new SolidColorBrush(Colors.Red);
                    if (brush != null)
                    {
                        for (int i = 0; i < seriescollection.Count; i++)
                        {
                            ((PieSeries)seriescollection[i]).Fill = brush;
                        }
                    }
                }
                else if (chartseries.getSeriesName() == "LineChart")
                {
                    seriescollection = chartseries.createChart();
                    brush = new SolidColorBrush(Colors.Red);
                    if (brush != null)
                    {
                        for (int i = 0; i < seriescollection.Count; i++)
                        {
                            ((LineSeries)seriescollection[i]).Fill = brush;
                        }
                    }
                }
            }
            return seriescollection;
        }

        public override void Show(DecoratorForm form)
        {
            if (chartseries.getSeriesName()=="PieChart")
            {
                piechart.Series = seriescollection;
                form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
                form.elementHost.Location = new System.Drawing.Point(0, 0);
                form.elementHost.Name = "elementHost";
                form.elementHost.Size = new System.Drawing.Size(984, 486);
                form.elementHost.TabIndex = 0;
                form.elementHost.Text = "elementHost";
                form.elementHost.Child = piechart;
                form.Controls.Add(form.elementHost);
            }
            else if (chartseries.getSeriesName() == "LineChart")
            {
                catersianchart.Series = seriescollection;
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

        public override string getSeriesName()
        {
            return chartseries.getSeriesName();
        }
    }
}
