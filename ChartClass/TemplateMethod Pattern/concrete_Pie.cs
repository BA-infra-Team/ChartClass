using ChartClass.Chart;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChartClass.Chart.cPieChart;

namespace ChartClass.TemplateMethod_Pattern
{
    public class concrete_Pie
    {        
        public class Pie_Chart : AbChart
        {
            public static ObserverForm obform = new ObserverForm();
            public PieChart piechart1 = new PieChart();
            //public cPieChart cpiechart = new cPieChart();
            public CustomChart chart;
            public override void draw()
            {
                chart = new CustomChart()
                {
                        new PieSeries()
                        {
                            Title = "test1",
                            Values = new ChartValues<double> { 31 },
                            DataLabels = true,
                            //LabelPoint = labelPoint,
                            Visibility = System.Windows.Visibility.Visible,
                        },

                        new PieSeries()
                        {
                            Title = "test2",
                            Values = new ChartValues<double> { 35 },
                            DataLabels = true,
                            //LabelPoint = labelPoint,
                            Visibility = System.Windows.Visibility.Visible,
                            Fill = System.Windows.Media.Brushes.YellowGreen,
                        },

                        new PieSeries()
                        {
                            Title = "test3",
                            Values = new ChartValues<double> { 35 },
                            DataLabels = true,
                            //LabelPoint = labelPoint,
                            Visibility = System.Windows.Visibility.Visible,
                            Fill = System.Windows.Media.Brushes.OrangeRed,
                        }
                };

                obform.panel1.Location = new Point(0, 0);
                obform.panel1.Size = new Size(300, 300);
                piechart1.Series = chart;
                obform.elementHost1.Child = piechart1;

                obform.Controls.Add(obform.panel1);
                obform.panel1.Controls.Add(obform.elementHost1);
                obform.elementHost1.Dock = DockStyle.Fill;

                obform.Show();
            }
        }
    }
}
