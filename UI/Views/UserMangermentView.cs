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
    public partial class UserMangermentView : UserControl
    {
        nhanvienDAO nhanvienDAO;
        List<nhanvien> nhanviens;
        DataTableStyle<nhanvien> tableStyle;
        public UserMangermentView()
        {
            InitializeComponent();
        }

        private void UserMangermentView_Load(object sender, EventArgs e)
        {
            Restart();
        }

        public void Restart()
        {
            pnlUsers.Controls.Clear();
            nhanvienDAO = new nhanvienDAO();
            nhanviens = nhanvienDAO.GetAll();
            var headers = new List<string>() { "Mã nhân viên", "Họ và tên", 
                "Địa chỉ", "Số điện thoại", "Chức vụ", "Giới tính", 
                "Ngày vào làm", "Tên đăng nhập", "Mật khẩu" };
            tableStyle = new DataTableStyle<nhanvien>(headers , nhanviens, true);
            foreach(var row in tableStyle.rowStyles)
            {
                row.editButton.Click += new EventHandler(delegate {
                    ViewModels.TabControl.OpenTab(new Tab(row.model.username, new ProfileView(row.model, true)));
                });
                row.removeButton.Click += new EventHandler(delegate {
                    try
                    {
                        nhanvienDAO.Remove(row.model);
                        Restart();
                    } catch
                    {
                        MessageBox.Show("Không thể xóa người dung này");
                    }
                });
            }
            pnlUsers.Controls.Add(tableStyle);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ViewModels.TabControl.OpenTab(new Tab("Tạo người dùng mới", new ProfileView(null, true)));
        }
    }
}
