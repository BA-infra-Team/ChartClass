using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ChartClass.cSeries;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartClass.Series
{
    public class cLineSeries : ChartSeries
    {
        public cLineSeries()
        {
            description = "나는 라인차트입니다.";
        }
        public override bool getDataLabels()
        {
            throw new NotImplementedException();
        }

        public override Brush getFill()
        {
            throw new NotImplementedException();
        }

        public override Func<ChartPoint, string> getLabelPoint()
        {
            throw new NotImplementedException();
        }

        public override double getOpacity()
        {
            throw new NotImplementedException();
        }

        public override Geometry getPointGeometry()
        {
            return DefaultGeometries.Square;
        }

        public override string getSeries()
        {
            return "LineSeries";
        }

        public override Brush getStroke()
        {
            Brush brush = new SolidColorBrush(Colors.Red);
            return brush;
        }

        public override double getStrokeThickness()
        {
            return 1;
        }

        public override string getTitle()
        {
            return description;
        }

        public override double getValue()
        {
            return 3;
        }
    }
}
