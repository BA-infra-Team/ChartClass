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
        public CustomPieChart piechart = new CustomPieChart();
        public ElementHost elementHost = new ElementHost();
        public StrategyForm()
        {
            InitializeComponent();

            //piechart.setColorBehavior(new DefaultColor_A());
            //piechart.setDataBehavior(new AddData_Single());
            piechart.setColorBehavior(new DefaultColor_B());
            piechart.setDataBehavior(new AddData_Multiple());
            piechart.performDataAdd(piechart.Series);
            piechart.performChangeColor(piechart.Series);

            piechart.Show(this);
        }
    }
}
