using ChartClass.cSeries;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.StrategyPattern.BehaviorClass
{
    public class AddData_Multiple : DataBehavior
    {
        public void AddData(SeriesCollection seriesCollection)
        {
            var rand = new Random();

            var value = new ChartValues<double>();

            for (int i = 0; i < 50; i++)
            {
                value.Add(rand.Next(1, 2000));
            }


            for (int i = 0; i < value.Count; i++)
            {
                seriesCollection.Add(new PieSeries()
                {
                    Title = "",
                    Values = new ChartValues<double>() { value[i] },
                }); ; 
            }
        }
    }
}
