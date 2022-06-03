using LiveCharts;
using LiveCharts.Wpf;
using System;

namespace ChartClass
{
    public class CustomPieChart : PieChart
    {
        public CustomPieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            this.Series = new SeriesCollection()
            {
                new PieSeries()
                {
                    Title = "hi",
                    Values = new ChartValues<double>{3},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Visibility = System.Windows.Visibility.Visible,
                },

                new PieSeries()
                {
                    Title = "hi2",
                    Values = new ChartValues<double>{3},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Visibility = System.Windows.Visibility.Visible,
                }
            };
            this.LegendLocation = LegendLocation.Bottom;
        }

        public void Show(Form1 form)
        {
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(0, 0);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(984, 486);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            form.elementHost.Child = this;
            form.Controls.Add(form.elementHost);
        }

        public void Show(StrategyForm form)
        {
            form.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            form.elementHost.Location = new System.Drawing.Point(0, 0);
            form.elementHost.Name = "elementHost";
            form.elementHost.Size = new System.Drawing.Size(984, 486);
            form.elementHost.TabIndex = 0;
            form.elementHost.Text = "elementHost";
            form.elementHost.Child = this;
            form.Controls.Add(form.elementHost);
        }

        // 차트 데이터 전체 삭제 
        public void All_Delete()
        {
            this.Series.Clear();
        }

        // 차트 데이터 추가 
        public void Add(string title, double value)
        {
            this.Series.Add(new PieSeries()
            { 
                Title = title,
                Values = new ChartValues<double>{value},
                DataLabels = true,
            });
        }

        // 차트 데이터 삭제
        public void Delete()
        {
            this.Series.RemoveAt(this.Series.Count-1);
        }

        // 차트 전체 숨기기 
        public void Hide()
        {
            //foreach (PieSeries ps in this.Series)
            //{
            //    ps.Visibility = Visibility.Hidden;
            //}
            this.Visibility = System.Windows.Visibility.Hidden; //인스턴스를 참조하여 액세스 할수 없습니다 형식을 이름을 사용하여 한정 하세요
        }

        // 차트 전체 보이기 
        public void ShowAll()
        {
            this.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
