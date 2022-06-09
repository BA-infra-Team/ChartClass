using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartesianChart = LiveCharts.Wpf.CartesianChart;

namespace ChartClass.TemplateMethod_Pattern
{
    public class concrete_Line
    {

        public class Line_Chart : AbChart
        {
			public static ObserverForm obform = new ObserverForm();
			public CustomChart chart;
			public CartesianChart catersianchart1 = new CartesianChart();
			public override void draw()
            {
				chart = new CustomChart()
				{
					new LineSeries()
					{
						Title = "Linechart1",
						Values = new ChartValues<double> {3,4,5,6,7}
					},
					new LineSeries()
					{
						Title = "Linechart2",
						Values = new ChartValues<double> {1,7,4,10,15 }
					},
					new LineSeries()
					{
						Title = "Linechart3",
						Values = new ChartValues<double> {10,8,4, 2, 1 }
					}
				};
				obform.panel2.Location = new Point(0, 0);
				obform.panel2.Size = new Size(300, 300);
				catersianchart1.Series = chart;
				obform.elementHost2.Child = catersianchart1;

				obform.Controls.Add(obform.panel2);
				obform.panel2.Controls.Add(obform.elementHost2);
				obform.elementHost2.Dock = DockStyle.Fill;
				//form2.Controls.Add(form2.panel2.Controls.Add(form2.elementHost2));
				obform.Show();
			}
        }
    }
}
