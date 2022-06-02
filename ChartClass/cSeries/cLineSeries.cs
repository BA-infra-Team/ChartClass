using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.cSeries
{
    public class cLineSeries : LineSeries
    {
        public cLineSeries(string _title, double _value)
        {
            this.Title = _title;
            this.Values = new ChartValues<double> { _value };
        }
    }
}
