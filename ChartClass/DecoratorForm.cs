using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using ChartClass.cSeries;
using ChartClass.Series;
using System.Windows.Forms.Integration;
using ChartClass.DecoratorPattern.Decorator;

namespace ChartClass
{
    public partial class DecoratorForm : Form
    {
        //public CartesianChart catersianchart = new CartesianChart();
        public ElementHost elementHost = new ElementHost();
        public DecoratorForm()
        {
            InitializeComponent();
            ChartSeries chartseries = new cBaseLineSeries(); // 3456
            //chartseries.createChart();
            //chartseries.Show(this);
            chartseries = new FillDeco(chartseries);    // 78910

            chartseries.createChart();
            chartseries.Show(this);

        }

    }
}
