using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cColumnSeries : ColumnSeries
    {
        public cColumnSeries(string _title, ChartValues<double> _value)
        {
            this.Title = _title;
            this.Values = _value;
        }
    }
}
