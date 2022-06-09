using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartClass.TemplateMethod_Pattern
{    
    public class concrete_Row
    {               
        public class Row_Chart : AbChart
        {
            public static ObserverForm obform = new ObserverForm();
            public CartesianChart catersianchart1 = new CartesianChart();
            public CustomChart chart;
            public override void draw()
            {
                chart = new CustomChart()
                {
                    new RowSeries()
                    {
                        Title = "aaa",
                        Values = new ChartValues<double> {3,4,5,6,7}
                    },
                    new RowSeries()
                    {
                        Title = "bbb",
                        Values = new ChartValues<double> {1,7,4,10,15}
                    },
                    new RowSeries()
                    {
                        Title = "ccc",
                        Values = new ChartValues<double> {10,8,4,2,1}
                    }
                };
                obform.panel1.Location = new Point(0, 0);
                obform.panel1.Size = new Size(300, 300);
                catersianchart1.Series = chart;
                obform.elementHost1.Child = catersianchart1;

                obform.Controls.Add(obform.panel1);
                obform.panel1.Controls.Add(obform.elementHost1);
                obform.elementHost1.Dock = DockStyle.Fill;

                obform.Show();
            }
        }
    }
}
