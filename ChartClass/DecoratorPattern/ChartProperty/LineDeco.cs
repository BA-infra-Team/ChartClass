using ChartClass.cSeries;
using ChartClass.DecoratorPattern.Decorator;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using System.Windows.Documents;

namespace ChartClass.DecoratorPattern.ChartProperty
{
    public class LineDeco : ChartDecorator
    {
        ChartSeries chartseries;
        public LineDeco(ChartSeries chartseries)
        {
            this.chartseries = chartseries;
        }
        public override string getTitle()
        {
            return chartseries.getTitle() + "+ 라인데코를 추가";
        }

        public override List<double> getValue()
        {
            value = chartseries.getValue();
            double[] values = { 7, 8, 9, 10 };

            value.AddRange(values);

            return value;
        }

    }
}
