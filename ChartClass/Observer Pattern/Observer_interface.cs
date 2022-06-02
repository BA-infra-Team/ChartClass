using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.Observer_Pattern
{
    internal class Observer_interface
    {
        public interface Observer
        {
            CustomChart update(int value);
        }
    }
}
