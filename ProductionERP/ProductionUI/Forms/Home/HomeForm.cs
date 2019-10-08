using LiveCharts;
using LiveCharts.Defaults;
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

namespace ProductionUI.Forms.Home
{
    public partial class HomeForm : Form
    {
        private Random rnd = new Random();

        public HomeForm()
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

        private void homeRefreshButton_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
