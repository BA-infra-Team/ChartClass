using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Wpf;

namespace ChartClass.cSeries
{
    public abstract class ChartSeries
    {
        public string description = "제목 없음";
        public abstract string getTitle();
        public abstract double value();
    }
}
