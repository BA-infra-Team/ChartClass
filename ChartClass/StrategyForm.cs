using ChartClass.StrategyPattern.BehaviorClass;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class StrategyForm : Form
    {
        //public CustomPieChart piechart = new CustomPieChart();
        public ElementHost elementHost = new ElementHost();
        public static CustomChart chart = new CustomChart();

        //public Panel LeftPanel
        //{
        //    get { return panel1; }
        //    set { panel1 = value; }
        //}
        //public Panel RightPanel
        //{
        //    get { return panel2; }
        //    set { panel2 = value; }
        //}
        public StrategyForm()
        {
            InitializeComponent();
            // 팩토리 + 전략패턴
            SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            ChartStore chartstore = new ChartStore(simpleChartFactory);
            chart = chartstore.orderChart("PieChart");
            chart.setColorBehavior(new DefaultColor_A());
            chart.setDataBehavior(new AddData_Multiple());
            chart.performDataAdd(chart, chart.name);
            chart.performChangeColor(chart, chart.name);
            //Thread.Sleep(5000);
            chart.Show(this);
        }
    }
}
