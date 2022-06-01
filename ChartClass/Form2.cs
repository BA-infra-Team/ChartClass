using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf.Charts.Base;
using ChartClass.cSeries;

namespace ChartClass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ChartSeries chartseries = new LineSeries();


        }
    }
}