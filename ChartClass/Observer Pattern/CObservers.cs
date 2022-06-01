using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using static ChartClass.Observer_Pattern.ConcreteSB;
using static ChartClass.Observer_Pattern.Observer_interface;
namespace ChartClass.Observer_Pattern
{
    internal class CObservers
    {
		
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
						Title = "hi33",
						Values = new ChartValues<double>{3, value},
						DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
					},

					new PieSeries()
					{
						Title = "hi211",
						Values = new ChartValues<double>{3, value},
						DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
					}
				};
				//piechart.Series = this;
				//form.elementHost.Child = piechart;
				Form1.Instance.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
				Form1.Instance.elementHost.Location = new System.Drawing.Point(0, 0);
				Form1.Instance.elementHost.Size = new System.Drawing.Size(984, 486);
				Form1.Instance.elementHost.Child = piechart1;
			}
		}

		public class LChart : Observer
		{
			private CustomChart chart;
			//private CustomChart chart;
			ConcreteSubject _subject;
			public LChart(ConcreteSubject subject)
			{
				_subject = subject;
				subject.registerObserver(this);
				
				
			}
			public void update(int value)
			{
				
				Console.WriteLine(String.Format("B Class update, value: {0}", value));
				chart = new CustomChart()
				{
					new LineSeries()
					{
						Title = "aaa",
						Values = new ChartValues<double> {3,4,5,6,7, value}
					},
					new LineSeries()
					{
						Title = "bbb",
						Values = new ChartValues<double> {1,7,4,10,15, value }
					},
					new LineSeries()
					{
						Title = "ccc",
						Values = new ChartValues<double> {10,8,4,2,1, value }
					}
				};
			}
		}

		public class RowChart : Observer
		{
			ConcreteSubject _subject;
			public RowChart(ConcreteSubject subject)
			{
				_subject = subject;
				subject.registerObserver(this);
			}
			public void update(int value)
			{
				Console.WriteLine(String.Format("C Class update, value: {0}", value));
			}
		}
	}
}
