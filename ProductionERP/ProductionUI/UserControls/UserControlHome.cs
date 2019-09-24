using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;

namespace ProductionUI.UserControls
{
    public partial class UserControlHome : UserControl
    {
        private Random rnd = new Random();

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void LoadChart()
        {
            weeklyReportChart.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15)),
                        new ObservablePoint(rnd.Next(0,15),rnd.Next(0,15))

                    },
                    PointGeometrySize = 15
                }
            };

        }

        private void HomeRefreshButton_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
