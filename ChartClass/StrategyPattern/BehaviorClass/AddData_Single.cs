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
        public void AddData(SeriesCollection seriesCollection, string name)
        {
            Random random_value = new Random();
            var value = random_value.Next(50, 400);

            if (name != null)
            {
                if (name == "PieChart")
                {
                    seriesCollection.Add(new cPieSeries("hi3", value));
                }
                else if (name == "LineChart")
                {
                    for (int i=0; i<seriesCollection.Count; i++)
                    {
                        seriesCollection[i].Values.Add((double)random_value.Next(50, 400));
                    }
                }
            }
        }
    }
}
