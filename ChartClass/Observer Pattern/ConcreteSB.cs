using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChartClass.Observer_Pattern.Observer_interface;

namespace ChartClass.Observer_Pattern
{
	public class ConcreteSB
	{
		public class ConcreteSubject : ChartSB_interface
		{
			IList _observers = new ArrayList();//observer 정보를 가지고 있는다
			int _value;
			public ConcreteSubject()
			{
				_value = 0;
			}
			public void notifyObservers()
			{
				foreach (Observer o in _observers)
					o.update(_value);
			}

			public void registerObserver(Observer o)
			{
				_observers.Add(o);
			}

			public void removeObserver(Observer o)
			{
				_observers.Remove(o);
			}
			public void setValue(int value)
			{
				_value = value;
				notifyObservers();
			}
		}
	}
}
