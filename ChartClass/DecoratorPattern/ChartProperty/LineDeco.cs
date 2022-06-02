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

            //ChartValues<double> chvalues2 = new ChartValues<double>();
            //for (int i = 0; i < chvalues.Count; i++)
            //{
            //    chvalues2.Add(chvalues[i]);
            //}
            //for (int i = 0; i < chvalues.Count; i++)
            //{
            //    chartseries.getValue().Add(chvalues[i]);
            //}
            //double values = 8;
            //values.Append(values);
            //return values.Add(chartseries.getValue());
        }

    }
}
