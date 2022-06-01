using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using static ChartClass.Observer_Pattern.CObservers;
using static ChartClass.Observer_Pattern.ConcreteSB;

namespace ChartClass
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static CustomPieChart custom = new CustomPieChart();
        public ElementHost elementHost = new ElementHost();
        public CustomChart chart = new CustomChart();
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //custom.Show(this);

            //SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            //ChartStore chartstore = new ChartStore(simpleChartFactory);
            //chart = chartstore.orderChart("PieChart");
            //chart.Show(this);

            //ConcreteSB concretesb = new ConcreteSB();
            ConcreteSubject concreteSubject = new ConcreteSubject();
            //PieChart Obser;
            PChart observerA = new PChart(concreteSubject);
            LChart observerB = new LChart(concreteSubject);
            concreteSubject.setValue(100);

        }

        private void 차트데이터추가ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            custom.Add("hi3", 5);
        }

        private void 차트데이터삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom.Delete();
        }

        private void 차트숨기기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom.Hide();
        }

        private void 차트보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom.ShowAll();
        }
    }
}
