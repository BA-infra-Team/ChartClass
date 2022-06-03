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
        //new ChartValues<double>
        public cLineSeries(string _title, ChartValues<double> _value)
        {
            this.Title = _title;
            this.Values = _value;
        }
    }
}
