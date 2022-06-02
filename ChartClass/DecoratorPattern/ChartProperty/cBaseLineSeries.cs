using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cBaseLineSeries : ChartSeries
    {
        public cBaseLineSeries()
        {
            description = "나는 라인차트입니다.";
        }

        public override string getTitle()
        {
            return description;
        }

        public override List<double> getValue()
        {
            List<double> values = new List<double> { 3,4,5,6};
            value.AddRange(values);
            return value;
        }
    }
}
