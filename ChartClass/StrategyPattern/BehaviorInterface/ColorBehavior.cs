using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChartClass.StrategyPattern.BehaviorInterface
{
    public interface ColorBehavior
    {
        void ChangeDefaultColor(SeriesCollection seriesCollection, string name);
    }
}
