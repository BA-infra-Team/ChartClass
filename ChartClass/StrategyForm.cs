using ChartClass.cSeries;
using ChartClass.StrategyPattern.BehaviorClass;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class StrategyForm : Form
    {
        //public CustomPieChart piechart = new CustomPieChart();
        public ElementHost elementHost = new ElementHost();
        public static CustomChart chart = new CustomChart();
        public StrategyForm()
        {
            InitializeComponent();

            // 팩토리 + 전략패턴
            SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            ChartStore chartstore = new ChartStore(simpleChartFactory);
            chart = chartstore.orderChart("PieChart");
            chart.setColorBehavior(new DefaultColor_A());
            chart.setColorBehavior(new DefaultColor_B());
            chart.setDataBehavior(new AddData_Multiple());
            chart.performDataAdd(chart,chart.name);
            chart.performChangeColor(chart,chart.name);
            chart.Show(this);

        }
    }
}
