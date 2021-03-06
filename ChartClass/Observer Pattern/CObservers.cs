using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using static ChartClass.Observer_Pattern.ConcreteSB;
using static ChartClass.Observer_Pattern.Observer_interface;
namespace ChartClass.Observer_Pattern
{
    public class CObservers
    {
		public static ObserverForm obform = new ObserverForm();
		//각 클래스 생성자에서 ConcreteSubject를 인자로 받고, registerObserver를 호출하여 자신을 옵저버로 등록
		public class PChart : Observer
		{
			
			private CustomChart chart;
			public PieChart piechart1 = new PieChart();
			ConcreteSubject _subject;
            //private CustomChart chart;
			
			

            public PChart(ConcreteSubject subject)
			{
				_subject = subject;
				subject.registerObserver(this);
			}
			public void update(int value)
			{
				chart = new CustomChart()
				{
					new PieSeries()
					{
						Title = "test1",
						Values = new ChartValues<double>{31, value},
						DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
						
					},

					new PieSeries()
					{
						Title = "test2",
						Values = new ChartValues<double>{35, value},
						DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
						Fill = System.Windows.Media.Brushes.YellowGreen,
					},
					
					new PieSeries()
					{
						Title = "test3",
						Values = new ChartValues<double>{35, value},
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
                //form2.Controls.Add(form2.panel2.Controls.Add(form2.elementHost2));
                obform.Show();
            }
		}

		public class LChart : Observer
		{
			private CustomChart chart;
			
			public CartesianChart catersianchart1 = new CartesianChart();
			ConcreteSubject _subject;

			public LChart(ConcreteSubject subject)
			{
				_subject = subject;
				subject.registerObserver(this);
				
				
			}
			public void update(int value)
			{
				
				//Console.WriteLine(String.Format("B Class update, value: {0}", value));
				chart = new CustomChart()
				{
					new LineSeries()
					{
						Title = "Linechart1",
						Values = new ChartValues<double> {3,4,5,6,7, value}
					},
					new LineSeries()
					{
						Title = "Linechart2",
						Values = new ChartValues<double> {1,7,4,10,15, value }
					},
					new LineSeries()
					{
						Title = "Linechart3",
						Values = new ChartValues<double> {10,8,4, value, 2, 1 }
					}
				};
				obform.panel2.Location = new Point(320, 320);
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

		public class Rchart : Observer
		{
			public CartesianChart catersianchart = new CartesianChart();

			private CustomChart chart;
			ConcreteSubject _subject;
			public Rchart(ConcreteSubject subject)
			{
				_subject = subject;
				subject.registerObserver(this);
			}
			public void update(int value)
			{
				CustomChart chart = new CustomChart();
				//Console.WriteLine(String.Format("C Class update, value: {0}", value));
				//Console.WriteLine(String.Format("C Class update, value: {0}", value));
				chart = new CustomChart()
				{
					new RowSeries()
					{
						Title = "eee",
						Values = new ChartValues<double> {30, 40, value, 5 }
					},
                    new RowSeries()
                    {
                        Title = "fff",
                        Values = new ChartValues<double> {10,70,4,10,15, value }
                    },
                    new RowSeries()
                    {
                        Title = "ggg",
                        Values = new ChartValues<double> {10,80,40,2,1, value }
                    }
                };

				obform.panel3.Location = new Point(310, 0);
				obform.panel3.Size = new Size(300, 300);
				catersianchart.Series = chart;
				obform.elementHost3.Child = catersianchart;

				obform.Controls.Add(obform.panel3);
				obform.panel3.Controls.Add(obform.elementHost3);
				obform.elementHost3.Dock = DockStyle.Fill;
				//form2.Controls.Add(form2.panel2.Controls.Add(form2.elementHost2));
				obform.Show();

			}
		}
	}
}
