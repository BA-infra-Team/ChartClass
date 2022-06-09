using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cRowSeries : RowSeries
    {
        public cRowSeries(string _title, ChartValues<double> _value)
        {
            this.Title = _title;
            this.Values = _value;
        }
    }
}
