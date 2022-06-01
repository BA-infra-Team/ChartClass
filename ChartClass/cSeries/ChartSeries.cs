using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Definitions.Series;
using System.Windows.Media;

namespace ChartClass.cSeries
{
    public abstract class ChartSeries : LiveCharts.Wpf.Series
    {
        public string description = "제목 없음";
        public abstract string getTitle();
        public abstract string getSeries();
        public abstract double getValue();

        public abstract Brush getFill();

        public abstract Func<ChartPoint, string> getLabelPoint();

        public abstract bool getDataLabels();

        public abstract Geometry getPointGeometry();

        public abstract Brush getStroke();

        public abstract double getStrokeThickness();

        public abstract double getOpacity();
        public ChartSeries()
        {
            this.Title = "제목 없음";
            this.Values = new ChartValues<double>();
            this.Fill = null;
            this.LabelPoint = null;
            this.DataLabels = null;
            this.PointGeometry = PointGeometry.;
            this.Stroke = null;
            this.StrokeThickness = null;
            this.Opacity = null;
        }

        public void SelectSeries()
        {
            if (getSeries() == "LineSeries")
            {
       
            }
        }

        public void Show()
        {
            if (getSeries() == "LineSeries")
            {
                new LineSeries() { };
            }
        }
    }
}
