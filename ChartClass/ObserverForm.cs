using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChartClass.Observer_Pattern.CObservers;
using static ChartClass.Observer_Pattern.ConcreteSB;

namespace ChartClass
{
    public partial class ObserverForm : Form
    {

        public Panel panel1 = new Panel();
        public System.Windows.Forms.Integration.ElementHost elementHost1 = new System.Windows.Forms.Integration.ElementHost();

        public Panel panel2 = new Panel();
        public System.Windows.Forms.Integration.ElementHost elementHost2 = new System.Windows.Forms.Integration.ElementHost();

        public Panel panel3 = new Panel();
        public System.Windows.Forms.Integration.ElementHost elementHost3 = new System.Windows.Forms.Integration.ElementHost();
        public ObserverForm()
        {
            InitializeComponent();

            ////ConcreteSB concretesb = new ConcreteSB();
            //ConcreteSubject concreteSubject = new ConcreteSubject();
            ////PieChart Obser;
            //PChart observerA = new PChart(concreteSubject);
            //LChart observerB = new LChart(concreteSubject);
            //concreteSubject.setValue(50);
            ////concreteSubject.removeObserver(observerA);
            ////concreteSubject.setValue(100);
            ////concreteSubject.registerObserver(observerA);
            ////concreteSubject.setValue(30);
        }
    }
}
