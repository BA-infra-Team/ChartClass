using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using ChartClass.cSeries;
using ChartClass.Series;
using ChartClass.DecoratorPattern.ChartProperty;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class DecoratorForm : Form
    {
        public CartesianChart catersianchart = new CartesianChart();
        public ElementHost elementHost = new ElementHost();
        public DecoratorForm()
        {
            InitializeComponent();
            ChartSeries chartseries = new cBaseLineSeries();
            chartseries = new LineDeco(chartseries);

            seriesCollection = new SeriesCollection
            {
                new LineSeries()
                {
                    Title = chartseries.getTitle(),
                    Values = new ChartValues<double>(chartseries.getValue())
                    //Values = chartseries.getValue(),
                },
            };


            catersianchart.Series = seriesCollection;

            this.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost.Location = new System.Drawing.Point(0, 0);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(984, 486);
            this.elementHost.TabIndex = 0;
            this.elementHost.Text = "elementHost";
            this.elementHost.Child = catersianchart;
            this.Controls.Add(this.elementHost);


        }
        public SeriesCollection seriesCollection { get; set; }
    }
}
