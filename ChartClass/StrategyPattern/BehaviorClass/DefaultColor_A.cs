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

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class DefaultColor_A : ColorBehavior
    {
        public void ChangeDefaultColor(SeriesCollection seriesCollection)
        {
            Brush brush = new SolidColorBrush(Colors.Red);
            for (int i = 0; i < seriesCollection.Count; i++)
            {
                ((PieSeries)seriesCollection[i]).Fill = brush;
            }
            //return brush;

        }
    }
}
