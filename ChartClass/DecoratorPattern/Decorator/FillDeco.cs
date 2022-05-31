using ChartClass.cSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.DecoratorPattern.Decorator
{
    public class FillDeco : ChartDecorator
    {
        ChartSeries chartSeries;
        public FillDeco(ChartSeries chartSeries)
        {
            this.chartSeries = chartSeries;
        }

        public override string getTitle()
        {
            return chartSeries.getTitle() + ", 채우기";
        }

        public override double value()
        {
            return .20 + chartSeries.value();
        }
    }
}
