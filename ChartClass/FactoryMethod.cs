using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using static ChartClass.Observer_Pattern.CObservers;
using static ChartClass.Observer_Pattern.ConcreteSB;

namespace ChartClass
{
    // 팩토리 패턴 
    public partial class FactoryMethod : Form
    {
        static FactoryMethod _obj;
        public static CustomPieChart custom = new CustomPieChart();
        public ElementHost elementHost = new ElementHost();
        public static CustomChart chart = new CustomChart();
        public static FactoryMethod Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FactoryMethod();
                }
                return _obj;
            }
        }

        public FactoryMethod()
        {
            InitializeComponent();
            //custom.Show(this);

            SimpleChartFactory simpleChartFactory = new SimpleChartFactory();
            ChartStore chartstore = new ChartStore(simpleChartFactory);
            chart = chartstore.orderChart("RowChart");
            chart.Show(this);


            //Observer Pattern
            ConcreteSubject concreteSubject = new ConcreteSubject();
            //PieChart Obser;
            PChart observerA = new PChart(concreteSubject);
            LChart observerB = new LChart(concreteSubject);
            Rchart observerC = new Rchart(concreteSubject);
            concreteSubject.setValue(50);
            //concreteSubject.removeObserver(observerA);
            //concreteSubject.setValue(100);
            //concreteSubject.registerObserver(observerA);
            //concreteSubject.setValue(30);

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
