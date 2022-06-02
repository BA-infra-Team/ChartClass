using ChartClass.DecoratorPattern.Decorator;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Windows.Forms;

namespace ChartClass
{
    public class CustomChart : SeriesCollection
    {
        private ColorBehavior colorBehavior;
        private DataBehavior dataBehavior;

        public PieChart piechart = new PieChart();
        public CartesianChart catersianchart = new CartesianChart();

        //private static CustomChart uniqueInstance;

        //private CustomChart() {}

        //public static CustomChart getInstance()
        //{
        //    if (uniqueInstance == null)
        //    {
        //        uniqueInstance = new CustomChart();
        //    }
        //    return uniqueInstance;
        //}
        public CustomChart() { }

        public string name;

        public void Show(FactoryMethod form)
        {
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(0, 0);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(984, 486);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            if (name != null)
            {
                if (name == "PieChart")
                {
                    piechart.Series = this;
                    form.elementHost.Child = piechart;
                }
                else if (name == "LineChart")
                {
                    catersianchart.Series = this;
                    form.elementHost.Child = catersianchart;
                }
            }
            form.Controls.Add(form.elementHost);
        }
        //public abstract void Hide();
        //public abstract void Add();
        //public abstract void Delete();    
        //public abstract void Show_All();

        public void getName(string Chartname)
        {
            name = Chartname;
        }
        //public void performChangeColor()
        //{
        //    colorBehavior.ChangeDefaultColor();
        //}
        //public void performDataAdd()
        //{
        //    dataBehavior.AddData();
        //}
        //public void setFlyBehavior(ColorBehavior cb)
        //{
        //    colorBehavior = cb;
        //}

        //public void setQuackBehavior(DataBehavior db)
        //{
        //    dataBehavior = db;
        //}
    }
}
