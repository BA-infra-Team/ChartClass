using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChartClass.Observer_Pattern.Observer_interface;

namespace ChartClass.Observer_Pattern
{
    internal class ChartSB_interface
    {
        public interface Subject
        {
            void registerObserver(Observer o); //등록
            void removeObserver(Observer o);//해제
            void notifyObservers();//갱신
        }
    }
}
