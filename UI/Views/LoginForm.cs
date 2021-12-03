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

namespace UI.Views
{
    public partial class LoginForm : Form
    {
        nhanvienDAO nhanvienDAO = new nhanvienDAO();
        List<nhanvien> nhanviens = new List<nhanvien>();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            nhanviens = nhanvienDAO.GetAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var nhanvien = nhanviens.FirstOrDefault(nv => nv.username == txbUsername.Text);
            if (nhanvien == null)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại");
                return;
            }
            if (nhanvien.password != txbPassword.Text)
            {
                MessageBox.Show("Mật khẩu không chính xác");
                return;
            }
            txbPassword.Text = "";
            var mainForm = new MainForm(nhanvien);
            mainForm.FormClosing += new FormClosingEventHandler(delegate {
                nhanviens = nhanvienDAO.GetAll();
                this.Show();
            });
            this.Hide();
            mainForm.Show();
        }
    }
}
