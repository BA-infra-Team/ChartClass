using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Forms;


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

        public override void Show(DecoratorForm form, ChartSeries chart, Panel panel, ElementHost elementHost)
        {
            if (chartseries.getSeriesName()=="PieChart")
            {
                piechart.Series = seriescollection;
                elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
                elementHost.Location = new System.Drawing.Point(0, 0);
                elementHost.Name = "elementHost";
                elementHost.Size = new System.Drawing.Size(984, 486);
                elementHost.TabIndex = 0;
                elementHost.Text = "elementHost";
                elementHost.Child = piechart;
                panel.Controls.Add(elementHost);

            }
            else if (chartseries.getSeriesName() == "LineChart")
            {
                catersianchart.Series = seriescollection;
                elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
                elementHost.Location = new System.Drawing.Point(0, 0);
                elementHost.Name = "elementHost";
                elementHost.Size = new System.Drawing.Size(984, 486);
                elementHost.TabIndex = 0;
                elementHost.Text = "elementHost";
                elementHost.Child = catersianchart;
                panel.Controls.Add(elementHost);
            }
        }

        public override string getSeriesName()
        {
            return chartseries.getSeriesName();
        }
    }
}
