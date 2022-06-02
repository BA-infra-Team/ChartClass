using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cBasePieSeries : ChartSeries
    {
        public cBasePieSeries()
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
