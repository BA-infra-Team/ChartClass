using ChartClass.StrategyPattern.BehaviorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using System.Windows.Media;
using LiveCharts.Wpf;
using ChartClass.cSeries;
using LiveCharts.Wpf.Points;

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class DefaultColor_A : ColorBehavior
    {
        PieChart piechart;
        enum DefaultColorSet
        {
            Red,   // 0
            Yellow,  // 1
            Blue,  // 2
            Black // 3
        }

        Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush> colors = new Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush>();
        public DefaultColor_A()
        {
            colors.Add(DefaultColorSet.Red, new SolidColorBrush(Colors.Red) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Yellow, new SolidColorBrush(Colors.Yellow) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Blue, new SolidColorBrush(Colors.Blue) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Black, new SolidColorBrush(Colors.Black) { Opacity = 0.15 });

        }
        public void ChangeDefaultColor(SeriesCollection seriesCollection, string name)
        {
            Array values = Enum.GetValues(typeof(DefaultColorSet));
            //Random rnd = new Random();

            if (name != null)
            {
                if (name == "PieChart")
                {
                    for (int i = 0; i < seriesCollection.Count; i++)
                    {
                        Random rnd = new Random();
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        ((PieSeries)seriesCollection[i]).Fill = someColor;
                        //((PieSeries)piechart.Series[i]).Fill = someColor;
                    }
                }
                else if (name == "LineChart")
                {
                    for (int i = 0; i < seriesCollection.Count; i++)
                    {
                        Random rnd = new Random();
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        ((LineSeries)seriesCollection[i]).Fill = someColor;
                    }
                }
            }
        }
    }
}
