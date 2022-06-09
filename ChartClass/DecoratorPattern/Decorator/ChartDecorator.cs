using ChartClass.cSeries;
using ChartClass.Series;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass.DecoratorPattern.Decorator
{
    public abstract class ChartDecorator : ChartSeries   // ChartSeries가 Beverage, CondimenDecorator = ChartDecorator
    {
        public abstract override SeriesCollection createChart();
        public abstract override void Show(DecoratorForm form, ChartSeries chart, Panel panel, ElementHost elementHost);

        public abstract override string getSeriesName();

        //public abstract 
        //public CustomChart makeChart()
        //{
        //}


    }
}
