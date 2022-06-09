using ChartClass.cSeries;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class DefaultColor_B : ColorBehavior
    {
        PieChart piechart = new PieChart();
        enum DefaultColorSet
        {
            Green,   // 0
            AliceBlue,  // 1
            LightCyan,  // 2
            Gray // 3
        }

        DefaultColorSet colorSet;

        Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush> colors = new Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush>();
        public DefaultColor_B()
        {
            colors.Add(DefaultColorSet.Green, new SolidColorBrush(Colors.Green) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.AliceBlue, new SolidColorBrush(Colors.AliceBlue) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.LightCyan, new SolidColorBrush(Colors.LightCyan) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Gray, new SolidColorBrush(Colors.Gray) { Opacity = 0.15 });

        }
        public void ChangeDefaultColor(SeriesCollection seriesCollection, string name)
        {
            Array values = Enum.GetValues(typeof(DefaultColorSet));
            Random rnd = new Random();

            if (name != null)
            {
                if (name == "PieChart")
                {
                    for (int i = 0; i < seriesCollection.Count; i++)
                    {
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        piechart.Series = seriesCollection;
                        ((PieSeries)piechart.Series[i]).Fill = someColor;
                        seriesCollection = piechart.Series;
                    }
                }
                else if (name == "LineChart")
                {
                    for (int i = 0; i < seriesCollection.Count; i++)
                    {
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        ((LineSeries)seriesCollection[i]).Fill = someColor;
                    }
                }
            }
        }
    }
}
