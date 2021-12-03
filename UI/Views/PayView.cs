using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using Data.DAO;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;

namespace UI.Views
{
    public partial class PayView : UserControl
    {
        banDAO banDAO = new banDAO();
        hoadonDAO hoadonDAO = new hoadonDAO();
        List<ban> bans = new List<ban>();
        List<TableStyle> tableStyles = new List<TableStyle>();
        ban currBan = new ban();
        hoadon currHD = new hoadon();
        List<DetailBill> detailBills = new List<DetailBill>();
        public PayView()
        {
            InitializeComponent();
            Init();
        }

        private void PayView_Load(object sender, EventArgs e)
        {
        }
        public void Init()
        {
            bans = banDAO.GetAll().OrderBy(b => int.Parse(b.ma_ban)).ToList();
            pnlTables.Controls.Clear();
            for (int i = 0; i < bans.Count; i++)
            {
                var tbStyle = new TableStyle(bans[i]);
                tbStyle.Location = new System.Drawing.Point(0, i * 150);
                int j = i;
                tbStyle.btnTable.Click += (sender, EventArgs) => BtnTable_Click(sender, EventArgs, bans[j]);
                tableStyles.Add(tbStyle);
                pnlTables.Controls.Add(tbStyle);
            }
        }
        private void BtnTable_Click(object sender, EventArgs e, ban ban)
        {
            if (!ban.thuoc_tinh)
            {
                MessageBox.Show("Bàn trống");
                return;
            }
            pnlPay.Visible = true;
            lblTable.Text = ban.ten_ban;
            currBan = ban;

            currHD = hoadonDAO.GetAll().FirstOrDefault(h => h.ma_ban == currBan.ma_ban && h.tong_tien == 0);

            detailBills = banDAO.Calc(ban);
            currHD.tong_tien = banDAO.Pay(ban);

            pnlBill.Controls.Clear();
            var headers = new List<string>() { "Tên", "Số lượng", "Giá", "Thành tiền" };
            var tableStyle = new DataTableStyle<DetailBill>(headers, detailBills, false);
            lblSum.Text = String.Format($"Tổng cộng: {currHD.tong_tien}");
            pnlBill.Controls.Add(tableStyle);
        }
        private void btnClosePay_Click(object sender, EventArgs e)
        {
            pnlPay.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CreatePDF();
            pnlPay.Visible = false;
            currBan.thuoc_tinh = false;
            hoadonDAO.Update(currHD);
            banDAO.Update(currBan);
            try
            {
                var nav = ViewModels.NavControl.navItems.FirstOrDefault(n => n.view is OrderView);
                if (nav != null)
                    (nav.view as OrderView).Init();
            }
            catch { }
            Init();
        }

        private void CreatePDF()
        {
            FormattedText bill = new FormattedText(String.Format($"{"HÓA ĐƠN",40}\n\n"));
            
            bill.AddNewLineText(LineFormat("Ngày", "", "", currHD.ngay_hd.ToString("dd-MM-yyyy")));
            bill.AddNewLineText(LineFormat("Mã hóa đơn:", "", "", currHD.ma_hd));
            bill.AddNewLineText("------------------------------------------------\n");
            bill.AddNewLineText(LineFormat("Tên đồ uống", "Số lượng", "Giá", "Thành tiền"));
            foreach (var d in detailBills)
            {
                bill.AddNewLineText(LineFormat(d.name, d.count.ToString(), d.price.ToString().ToString(), d.total.ToString()));
            }
            bill.AddNewLineText("\n------------------------------------------------\n");
            bill.AddNewLineText(LineFormat("Tổng tiền:", "", "", currHD.tong_tien.ToString()));
            Document document = new Document();
            TextStamp textStamp = new TextStamp(bill);
            textStamp.TopMargin = 50;
            textStamp.TextState.Font = FontRepository.FindFont("Consolas");
            textStamp.TextState.FontSize = 14.0F;
            textStamp.TextState.FontStyle = FontStyles.Bold;
            textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            textStamp.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Left;
            textStamp.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            document.Pages.Add();
            document.Pages[1].AddStamp(textStamp);
            document.Save("bill.pdf");
            BillForm billForm = new BillForm();
            billForm.Show();
        }
        string LineFormat(string col1, string col2, string col3, string col4)
        {
            string res = "";
            res += col1;
            while (res.Length < 30) res += " ";
            res += col2;
            while (res.Length < 40) res += " ";
            res += col3;
            while (res.Length < 50) res += " ";
            res += col4;
            return res;
        }
    }
}
