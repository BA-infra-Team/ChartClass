using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ChartClass.cSeries;
using ChartClass.Series;

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
                    new cPieSeries("hi",3),
                    new cPieSeries("hi2",5)                    
                };
                chart.name = "PieChart";

            }
            else if (type.Equals("LineChart"))
            {
                //CustomChart chart = null;
                //chart = new SeriesCollection
                chart = new CustomChart()
                {
                    new cLineSeries("aaa",new ChartValues<double>{30,40,50,66,7}),
                    new cLineSeries("bbb",new ChartValues<double>{10,70,4,10,15}),
                    new cLineSeries("ccc",new ChartValues<double>{100,8,4,2,1}),
                };
                chart.name = "LineChart";
            }
            else if (type.Equals("RowChart"))
            {
                chart = new CustomChart()
                {
                    new cRowSeries("aaa",new ChartValues<double>{3,4,5,6,7}),
                    new cRowSeries("bbb",new ChartValues<double>{1,7,4,10,15}),
                    new cRowSeries("ccc",new ChartValues<double>{10,8,4,2,1}),
                };
                chart.name = "RowChart";
            }
            
            return chart;
        }
    }
}
