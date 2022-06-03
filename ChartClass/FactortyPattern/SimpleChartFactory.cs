using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public class SimpleChartFactory 
    {
        public CustomChart chart;
        // string type -> CustomPieChart type 
        public CustomChart createChart(string type)
        {
            //CustomChart chart = new CustomChart();
            //CustomPieChart chart = null;

            if (type.Equals("PieChart"))
            {
                //CustomChart chart = null;
                chart = new CustomChart()
                {
                    new PieSeries()
                    {
                        Title = "hi",
                        Values = new ChartValues<double>{3},
                        DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
                    },

                    new PieSeries()
                    {
                        Title = "hi2",
                        Values = new ChartValues<double>{3},
                        DataLabels = true,
                        //LabelPoint = labelPoint,
                        Visibility = System.Windows.Visibility.Visible,
                    }
                };
                chart.name = "PieChart";

            }
            else if (type.Equals("LineChart"))
            {
                //CustomChart chart = null;
                //chart = new SeriesCollection
                chart = new CustomChart()
                {
                    new LineSeries()
                    {
                        Title = "aaa",
                        Values = new ChartValues<double> {3,4,5,6,7}
                    },
                    new LineSeries()
                    {
                        Title = "bbb",
                        Values = new ChartValues<double> {1,7,4,10,15}
                    },
                    new LineSeries()
                    {
                        Title = "ccc",
                        Values = new ChartValues<double> {10,8,4,2,1}
                    }
                };
                chart.name = "LineChart";
            }
            else if (type.Equals("RowChart"))
            {
                chart = new CustomChart()
                {
                    new RowSeries()
                    {
                        Title = "aaa",
                        Values = new ChartValues<double> {3,4,5,6,7}
                    },
                    new RowSeries()
                    {
                        Title = "bbb",
                        Values = new ChartValues<double> {1,7,4,10,15}
                    },
                    new RowSeries()
                    {
                        Title = "ccc",
                        Values = new ChartValues<double> {10,8,4,2,1}
                    }
                };
                chart.name = "RowChart";
            }
            
            return chart;
        }
    }
}
