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
        public void AddData(SeriesCollection seriesCollection, string name)
        {
            var rand = new Random();
            var value = new ChartValues<double>();

            for (int i = 0; i < 50; i++)
            {
                value.Add(rand.Next(1, 2000));
            }

            if (name != null)
            {
                if (name == "PieChart")
                {
                    for (int i = 0; i < value.Count; i++)
                    {
                        seriesCollection.Add(new cPieSeries("", value[i]));
                    }
                }
                else if (name == "LineChart")
                {
                    for (int i = 0; i < seriesCollection.Count; i++)
                    {
                        for(int j=0; j< value.Count; j++)
                        {
                            seriesCollection[i].Values.Add(value[j]);
                        }
                    }
                }
            }
        }
    }
}
