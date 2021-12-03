using Data.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views
{
    public partial class RevenueView : UserControl
    {
        hoadonDAO hoadonDAO = new hoadonDAO();
        int month, year;
        public RevenueView()
        {
            InitializeComponent();
        }

        private void RevenueView_Load(object sender, EventArgs e)
        {
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            cbbMonth.Text = month.ToString();
            cbbYear.Text = year.ToString();
            cbbType.DataSource = Enum.GetValues(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesChartType));
            cbbType.SelectedItem = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            Init();
        }

        void Init()
        {
            DataTable db = new DataTable();
            chartRevenue.Series["Revenue"].YValueMembers = "doanh_thu";            
            chartRevenue.Series["Revenue"].IsValueShownAsLabel = true;
            if (year == 0)
            {
                db = hoadonDAO.Revenue();
                chartRevenue.Titles.Clear();
                chartRevenue.Titles.Add("Doanh thu các năm");
                chartRevenue.Series["Revenue"].XValueMember = "nam";
            }
            else if (month == 0)
            {
                db = hoadonDAO.Revenue(year);
                chartRevenue.Titles.Clear();
                chartRevenue.Titles.Add(String.Format($"Doanh thu năm {year}"));
                chartRevenue.Series["Revenue"].XValueMember = "thang";
            }
            else
            {
                db = hoadonDAO.Revenue(month, year);
                chartRevenue.Titles.Clear();
                chartRevenue.Titles.Add(String.Format($"Doanh thu tháng {month} năm {year}"));
                chartRevenue.Series["Revenue"].XValueMember = "ngay";
            }
            chartRevenue.DataSource = db;
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbYear.Text == "none")
                year = 0;
            else
                year = Convert.ToInt32(cbbYear.Text);
            Init();
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartRevenue.Series["Revenue"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cbbType.SelectedItem;
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonth.Text == "none")
                month = 0;
            else
                month = Convert.ToInt32(cbbMonth.Text);
            Init();
        }
    }
}
