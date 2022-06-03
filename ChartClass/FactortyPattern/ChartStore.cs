using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartClass
{
    public class ChartStore
    {
        SimpleChartFactory factory;
        //private readonly Form1 form;

        public ChartStore(SimpleChartFactory factory)
        {
            this.factory = factory;
        }

        public CustomChart orderChart(string type)
        {
            CustomChart chart;
            chart = factory.createChart(type);

            // 기타 함수 (ex : 피자면 prepare, bake, cut, box 
            //Form1.Instance.Show();


            return chart;
        }
    }
}
