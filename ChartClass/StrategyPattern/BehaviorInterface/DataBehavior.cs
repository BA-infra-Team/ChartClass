using ChartClass.cSeries;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Wpf;

namespace ChartClass.StrategyPattern.BehaviorInterface
{
    public interface DataBehavior
    {
        void AddData(SeriesCollection seriesCollection);
    }
}
