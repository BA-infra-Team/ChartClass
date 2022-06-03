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

namespace ChartClass.cSeries
{
    public abstract class ChartSeries : LiveCharts.Wpf.Series
    {

        public string description = "제목 없음";

        public List<double> value = new List<double>();
        public abstract string getTitle();
        public abstract List<double> getValue();

        //public abstract string getSeries();
        //public abstract Brush getFill();
        //public abstract Func<ChartPoint, string> getLabelPoint();
        //public abstract bool getDataLabels();
        //public abstract Geometry getPointGeometry();
        //public abstract Brush getStroke();
        //public abstract double getStrokeThickness();
        //public abstract double getOpacity();

        public ChartSeries()
        {

        }
    }
}
