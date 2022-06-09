using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.AdapterPattern
{
    public class Adapter : CustomChart, IChartMaker
    {
        Adaptee adaptee = new Adaptee();
        public override CustomChart request(CustomChart chart)
        {
            chart = adaptee.SpecificRequest(chart);
            return chart;
        }
    }
}
