using ChartClass.cSeries;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class AddData_Single : DataBehavior
    {
        public void AddData(SeriesCollection seriesCollection)
        {
            Random random_value = new Random();
            var value = random_value.Next(50, 400);

            seriesCollection.Add(new PieSeries
            {
                Title = "hi3",
                Values = new ChartValues<double> { value }
            });
        }
    }
}
