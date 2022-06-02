using ChartClass.cSeries;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Media;

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class DefaultColor_B : ColorBehavior
    {
        public void ChangeDefaultColor(SeriesCollection seriesCollection)
        {
            // 디폴트 컬러 B 군으로 설정 
            Brush brush = new SolidColorBrush(Colors.Yellow);
            for (int i = 0; i < seriesCollection.Count; i++)
            {
                ((PieSeries)seriesCollection[i]).Fill = brush;
            }
        }

    }
}
