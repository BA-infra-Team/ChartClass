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
        ChartSeries Leftchartseries = new cBaseLineSeries();
        ChartSeries Rightchartseries = new cBaseLineSeries();

        public ElementHost LeftelementHost = new ElementHost();
        public ElementHost RightelementHost = new ElementHost();

        public Panel LeftPanel
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        public Panel RightPanel
        {
            get { return panel2; }
            set { panel2 = value; }
        }
        public DecoratorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Leftchartseries.createChart();
            Leftchartseries.Show(this, Leftchartseries, LeftPanel,LeftelementHost);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChartSeries chartseries = new cBaseLineSeries();
            Rightchartseries = new FillDeco(Rightchartseries);
            Rightchartseries.createChart();
            Rightchartseries.Show(this, Rightchartseries, RightPanel, RightelementHost);
        }
    }
}
