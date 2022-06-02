using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChartClass.Observer_Pattern.Observer_interface;

namespace ChartClass.Observer_Pattern
{
    internal class ConcreteSB
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

			public void Show(Form1 form, ConcreteSubject concreteSubject)
            {
				//form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
				//form.elementHost.Location = new System.Drawing.Point(0, 0);
				//form.elementHost.Name = "elementHost";
				//form.elementHost.Size = new System.Drawing.Size(984, 486);
				//form.elementHost.TabIndex = 0;
				//form.elementHost.Text = "elementHost";
				//form.elementHost.Child = piechart1;
				//form.Controls.Add(form.elementHost);
			}
		}
	}
}
