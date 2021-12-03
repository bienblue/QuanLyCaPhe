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
    public partial class OrderView : UserControl
    {
        banDAO banDAO = new banDAO();
        loaihangDAO loaihangDAO = new loaihangDAO();
        hanghoaDAO hanghoaDAO = new hanghoaDAO();
        chi_tiet_ban_hangDAO chi_Tiet_Ban_HangDAO = new chi_tiet_ban_hangDAO();
        hoadonDAO hoadonDAO = new hoadonDAO();

        List<ban> bans = new List<ban>();
        List<loaihang> loaihangs = new List<loaihang>();
        List<hanghoa> hanghoas = new List<hanghoa>();

        List<TableStyle> tableStyles = new List<TableStyle>();
        List<MenuStyle> menuStyles = new List<MenuStyle>();

        ban currBan = new ban();
        nhanvien currUser = new nhanvien();

        public OrderView()
        {
            InitializeComponent();
        }

        public OrderView(nhanvien user) : this()
        {
            currUser = user;
        }

        public void Init()
        {
            btnOrder.Click -= BtnOrder_Click;
            btnOrder.Click += BtnOrder_Click;
            bans = banDAO.GetAll().OrderBy(b => int.Parse(b.ma_ban)).ToList();
            loaihangs = loaihangDAO.GetAll();
            hanghoas = hanghoaDAO.GetAll();
            menuStyles.Clear();
            pnlTables.Controls.Clear();     
            for(int i = 0; i < bans.Count; i++)
            {
                var tbStyle = new TableStyle(bans[i]);
                tbStyle.Location = new Point(0, i*150);
                int j = i;
                tbStyle.btnTable.Click += (sender, EventArgs) => BtnTable_Click(sender, EventArgs, bans[j]);
                tableStyles.Add(tbStyle);
                pnlTables.Controls.Add(tbStyle);
            }

            pnlMenu.Controls.Clear();
            foreach(var lh in loaihangs)
            {
                var lstHH = hanghoas.Where(h => h.ma_lh == lh.ma_lh).ToList();
                var mnStyle = new MenuStyle(lstHH)
                {
                    Dock = DockStyle.Top
                };
                mnStyle.btnType.Text = lh.ten_lh;
                pnlMenu.Controls.Add(mnStyle);
                menuStyles.Add(mnStyle);
            }
        }

        private void BtnTable_Click(object sender, EventArgs e, ban ban)
        {
            if(ban.thuoc_tinh)
            {
                MessageBox.Show("Bàn đã có người ngồi");
                return;
            }
            pnlOrder.Visible = true;
            lblTable.Text = ban.ten_ban;
            currBan = ban;
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            pnlOrder.Visible = false;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            var hoadon = new hoadon()
            {
                ma_hd = String.Format($"HD{DateTime.Now.ToString("hhmmssyyyyMMdd")}"),
                ngay_hd = DateTime.Now,
                tong_tien = 0,
                ma_ban = currBan.ma_ban,
                ma_nv = currUser.ma_nv
            };
            hoadonDAO.Add(hoadon);

            int sum = 0;
            foreach(var type in menuStyles)
            {
                for(int i = 0; i < type.menuRowStyles.Count; i++)
                {
                    if (type.menuRowStyles[i].nudCount.Value > 0) {
                        var detail = new chi_tiet_ban_hang()
                        {
                            ma_hd = hoadon.ma_hd,
                            ma_hh = type.hanghoas[i].ma_hh,
                            so_luong = ((int)type.menuRowStyles[i].nudCount.Value)
                        };
                        chi_Tiet_Ban_HangDAO.Add(detail);
                        sum += detail.so_luong * type.hanghoas[i].gia_sp;
                    }
                }
            }

            if (sum > 0)
                hoadonDAO.Update(hoadon);
            else
            {
                hoadonDAO.Remove(hoadon);
                MessageBox.Show("Cần chọn ít nhất một đồ uống");
                return;
            }
            currBan.thuoc_tinh = true;
            banDAO.Update(currBan);
            pnlOrder.Visible = false;
            try
            {
                var nav = ViewModels.NavControl.navItems.FirstOrDefault(n => n.view is PayView);
                if (nav != null)
                    (nav.view as PayView).Init();
            } catch { }
            Init();
        }
    }
}
