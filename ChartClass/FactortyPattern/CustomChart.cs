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
        public PieChart piechart = new PieChart();
        public CartesianChart catersianchart = new CartesianChart();

        public string name;
        public CustomChart()
        {

        }
        

        public void Show(Form1 form)
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
                else if(name == "LineChart")
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
    }
}
