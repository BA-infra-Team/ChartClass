using ChartClass.AdapterPattern;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class AdapterForm : Form
    {
        public ElementHost LeftelementHost = new ElementHost();
        public CustomChart Leftchart = new CustomChart();

        public ElementHost RightelementHost = new ElementHost();
        public CustomChart Rightchart = new CustomChart();

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
        public AdapterForm()
        {
            InitializeComponent();
            SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            ChartStore chartstore = new ChartStore(simpleChartFactory);
            Leftchart = chartstore.orderChart("PieChart");
            Rightchart = chartstore.orderChart("PieChart");

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Leftchart = Leftchart.request(Leftchart);
            Leftchart.Show(this, Leftchart, LeftPanel,LeftelementHost);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            CustomChart Target = new Adapter();
            Rightchart = Target.request(Rightchart);
            Rightchart.Show(this, Rightchart, RightPanel,RightelementHost);
        }
    }
}
