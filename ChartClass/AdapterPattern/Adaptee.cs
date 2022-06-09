using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChartClass.AdapterPattern
{
    public class Adaptee
    {
        PieChart piechart = new PieChart();
        enum DefaultColorSet
        {
            Red,   // 0
            Yellow,  // 1
            Blue,  // 2
            Black // 3
        }

        Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush> colors = new Dictionary<DefaultColorSet, System.Windows.Media.SolidColorBrush>();
        public Adaptee()
        {
            colors.Add(DefaultColorSet.Red, new SolidColorBrush(Colors.Red) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Yellow, new SolidColorBrush(Colors.Yellow) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Blue, new SolidColorBrush(Colors.Blue) { Opacity = 0.15 });
            colors.Add(DefaultColorSet.Black, new SolidColorBrush(Colors.Black) { Opacity = 0.15 });
        }
        public CustomChart SpecificRequest(CustomChart chart)
        {
            Array values = Enum.GetValues(typeof(DefaultColorSet));
            Random rnd = new Random();

            if (chart.name != null)
            {
                if (chart.name == "PieChart")
                {
                    for (int i = 0; i < chart.Count; i++)
                    {
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        //((PieSeries)seriesCollection[i]).Fill = someColor;
                        piechart.Series = chart;
                        ((PieSeries)piechart.Series[i]).Fill = someColor;
                        chart = (CustomChart)piechart.Series;
                    }
                    return chart;
                }
                else if (chart.name == "LineChart")
                {
                    for (int i = 0; i < chart.Count; i++)
                    {
                        DefaultColorSet randomBar = (DefaultColorSet)values.GetValue(rnd.Next(values.Length));
                        SolidColorBrush someColor = colors[randomBar];
                        ((LineSeries)chart[i]).Fill = someColor;
                    }
                    return chart;
                }
            }
            return chart;
        }
    }
}
