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
using UI.ViewModels;

namespace UI.Views
{
    public partial class EditMenuView : UserControl
    {
        hanghoaDAO hanghoaDAO = new hanghoaDAO();
        loaihangDAO loaihangDAO = new loaihangDAO();
        List<hanghoa> hanghoas = new List<hanghoa>();
        DataTableStyle<hanghoa> tableStyle = new DataTableStyle<hanghoa>();

        hanghoa currHH = new hanghoa();
        bool isEdit = true;

        public EditMenuView()
        {
            InitializeComponent();
        }

        private void EditMenuView_Load(object sender, EventArgs e)
        {
            cbbType.Items.Clear();
            foreach (var lh in loaihangDAO.GetAll())
            {
                cbbType.Items.Add(lh.ten_lh);
            }
            Restart();
        }

        public void Restart()
        {
            pnlDrinks.Controls.Clear();
            hanghoas = hanghoaDAO.GetAll();
            var headers = new List<string>() { "Mã", "Tên", "Số lượng", "Giá", "Loại" };
            tableStyle = new DataTableStyle<hanghoa>(headers, hanghoas, true);
            foreach (var row in tableStyle.rowStyles)
            {
                row.editButton.Click += new EventHandler(delegate
                {
                    pnlEdit.Visible = true;
                    isEdit = true;
                    currHH = row.model;
                    FillDrink(currHH);
                });
                row.removeButton.Click += new EventHandler(delegate
                {
                    try
                    {
                        hanghoaDAO.Remove(row.model);
                        Restart();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa đồ uống");
                    }
                });
            }
            pnlDrinks.Controls.Add(tableStyle);
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            isEdit = false;
            currHH = new hanghoa();
            FillDrink(currHH);
        }

        void FillDrink(hanghoa hh)
        {
            txbId.Enabled = !isEdit;
            txbId.Text = hh.ma_hh;
            txbName.Text = hh.ten_hh;
            txbCount.Text = hh.soluong.ToString();
            txbPrice.Text = hh.gia_sp.ToString();
            var type = loaihangDAO.GetAll().FirstOrDefault(l => l.ma_lh == hh.ma_lh);
            if (type != null)
                cbbType.Text = type.ten_lh;
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                currHH.ma_hh = txbId.Text;
                currHH.ten_hh = txbName.Text;
                currHH.soluong = Convert.ToInt32(txbCount.Text);
                currHH.gia_sp = Convert.ToInt32(txbPrice.Text);
                var type = loaihangDAO.GetAll().First(l => l.ten_lh == cbbType.Text);
                currHH.ma_lh = type.ma_lh;
                if (isEdit)
                    hanghoaDAO.Update(currHH);
                else
                    hanghoaDAO.Add(currHH);
                pnlEdit.Visible = false;
                Restart();
            }
            catch
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }
        }
    }
}
