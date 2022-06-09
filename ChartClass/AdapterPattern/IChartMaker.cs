using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.AdapterPattern
{
    public interface IChartMaker
    {
        CustomChart request(CustomChart chart); // Fill 색상을 채우시오 
    }
}
