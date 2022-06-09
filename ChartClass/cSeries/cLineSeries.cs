using ChartClass.AdapterPattern;
using LiveCharts;
using LiveCharts.Wpf;

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
