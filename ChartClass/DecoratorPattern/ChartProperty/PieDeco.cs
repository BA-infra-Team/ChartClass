using ChartClass.DecoratorPattern.Decorator;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.DecoratorPattern.ChartProperty
{
    public class PieDeco : ChartDecorator
    {
        public PieDeco()
        {
            description = "나는 파이차트입니다.";
        }
        public override string getTitle()
        {
            return description;
        }

        public override List<double> getValue()
        {
            List<double> values = new List<double> { 3, 4, 5, 6 };
            return values;
        }
    }
}
