using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Definitions.Series;
using System.Windows.Media;
using ChartClass.StrategyPattern.BehaviorInterface;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass.cSeries
{
    public abstract class ChartSeries : SeriesCollection
    {
        public string SeriesName = "제목 없음";
        public abstract SeriesCollection createChart();
        public abstract void Show(DecoratorForm form, ChartSeries chart, Panel panel, ElementHost elementHost);

        public abstract string getSeriesName();
        public ChartSeries()
        {
            
        }

    }
}
