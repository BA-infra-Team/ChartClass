using ChartClass.StrategyPattern.BehaviorClass;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class StrategyForm : Form
    {
        public  CustomChart Leftchart = new CustomChart();
        public  CustomChart Rightchart = new CustomChart();

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

        public StrategyForm()
        {
            InitializeComponent();
            // 팩토리 + 전략패턴
            SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            ChartStore chartstore = new ChartStore(simpleChartFactory);
            Leftchart = chartstore.orderChart("PieChart");
            Rightchart = chartstore.orderChart("PieChart");

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Leftchart.setColorBehavior(new DefaultColor_A());
            Leftchart.setDataBehavior(new AddData_Single());
            Leftchart.performDataAdd(Leftchart, Leftchart.name);
            Leftchart.performChangeColor(Leftchart, Leftchart.name);
            Leftchart.Show(this, Leftchart, LeftPanel, LeftelementHost);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Rightchart.setColorBehavior(new DefaultColor_B());
            Rightchart.setDataBehavior(new AddData_Multiple());
            Rightchart.performDataAdd(Rightchart, Rightchart.name);
            Rightchart.performChangeColor(Rightchart, Rightchart.name);
            Rightchart.Show(this, Rightchart, RightPanel, RightelementHost);
        }
    }
}
