using ChartClass.cSeries;
using ChartClass.Series;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartClass.FacadePattern
{
    public class ChartFacade
    {
        cLineSeries line;
        cPieSeries pie;
        cRowSeries row;
        cColumnSeries column;
        CustomChart chart;

        PieChart piechart = new PieChart();
        CartesianChart catersianChart = new CartesianChart();


        public ChartFacade(cLineSeries line, cPieSeries pie, cRowSeries row, cColumnSeries column, CustomChart chart)
        {
            this.line = line;
            this.pie = pie;
            this.row = row;
            this.column = column;
            this.chart = chart;
        }

        public void createPieChart(CustomChart chart)
        {
            chart.Add(pie);
            chart.name = "PieChart";
        }
        public void createCatersianChart(CustomChart chart)
        {
            chart.Add(line);
            chart.name = "LineChart";
        }
        public void showChart(FacadeForm form, CustomChart chart)
        {
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(100, 100);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(800, 500);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            if (chart.name != null)
            {
                if (chart.name == "PieChart")
                {
                    piechart.Series = chart;
                    form.elementHost.Child = piechart;

                }
                else if (chart.name == "LineChart")
                {
                    catersianChart.Series = chart;
                    form.elementHost.Child = catersianChart;
                }
            }
            form.Controls.Add(form.elementHost);
        }

        public void hideChart()
        {

        }
    }
}
