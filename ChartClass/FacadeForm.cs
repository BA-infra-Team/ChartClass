using ChartClass.cSeries;
using ChartClass.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using ChartClass.FacadePattern;
using System.Windows.Forms.Integration;

namespace ChartClass
{
    public partial class FacadeForm : Form
    {
		public ElementHost elementHost = new ElementHost();
		public FacadeForm()
        {
			cLineSeries line = new cLineSeries("hi",new ChartValues<double> { 3,4});
			cPieSeries pie = new cPieSeries("hi",4);
			cRowSeries row = new cRowSeries("hi",new ChartValues<double> { 3, 4 });
			cColumnSeries column = new cColumnSeries("hi", new ChartValues<double> { 3, 4 });
			CustomChart chart = new CustomChart();

			ChartFacade chartFacade =
					new ChartFacade(line, pie, row, column,chart);

			//chartFacade.createPieChart(chart);
			chartFacade.createCatersianChart(chart);
			chartFacade.showChart(this,chart);
			InitializeComponent();
        }
    }
}
