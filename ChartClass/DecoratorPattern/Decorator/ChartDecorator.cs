using ChartClass.cSeries;
using ChartClass.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.DecoratorPattern.Decorator
{
    public abstract class ChartDecorator : ChartSeries   // ChartSeries가 Beverage, CondimenDecorator = ChartDecorator
    {
        public abstract override string getTitle();
        public abstract override double value();

    }
}
