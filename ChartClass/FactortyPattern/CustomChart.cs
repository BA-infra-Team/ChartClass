using ChartClass.DecoratorPattern.Decorator;
using ChartClass.StrategyPattern.BehaviorInterface;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;

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

        public string name;

        public CustomChart() 
        {

        }
        public void Show(FactoryMethod form)
        {
            //form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(100, 100);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(300, 300);
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
        public void Show(AdapterForm form, CustomChart chart, Panel panel,ElementHost elementhost)
        {
            elementhost.Dock = System.Windows.Forms.DockStyle.Fill;
            elementhost.Location = new System.Drawing.Point(0, 0);
            elementhost.Name = "elementHost";
            elementhost.Size = new System.Drawing.Size(984, 486);
            elementhost.TabIndex = 0;
            elementhost.Text = "elementHost";
            if (name != null)
            {
                if (name == "PieChart")
                {
                    piechart.Series = chart;
                    elementhost.Child = piechart;
                }
                else if (name == "LineChart")
                {
                    catersianchart.Series = chart;
                    elementhost.Child = catersianchart;
                }
                else if (name == "RowChart")
                {
                    catersianchart.Series = chart;
                    elementhost.Child = catersianchart;
                }
            }
            //form.Controls.Add(form.LeftPanel);
            panel.Controls.Add(elementhost);
        }
        public void Show(StrategyForm form)
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
                else if(name == "RowChart")
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

        public virtual CustomChart request(CustomChart chart)
        {
            Console.WriteLine("Called Target Request");
            if(name!= null)
            {
                if (chart.name == "PieChart")
                {
                    for (int i = 0; i < chart.Count; i++)
                    {
                        ((PieSeries)this[i]).Fill = new SolidColorBrush(Colors.Red);
                    }
                }
                else if (chart.name == "LineChart")
                {
                    for (int i = 0; i < chart.Count; i++)
                    {
                        ((LineSeries)this[i]).Fill = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            return chart;
        }

        public void getName(string Chartname)
        {
            name = Chartname;
        }
        public void performChangeColor(SeriesCollection seriesCollection, string name)
        {
            colorBehavior.ChangeDefaultColor(seriesCollection, name);
        }
        public void performDataAdd(SeriesCollection seriesCollection, string name)
        {
            dataBehavior.AddData(seriesCollection, name);
        }
        public void setColorBehavior(ColorBehavior cb)
        {
            colorBehavior = cb;
        }

        public void setDataBehavior(DataBehavior db)
        {
            dataBehavior = db;
        }
    }
}
