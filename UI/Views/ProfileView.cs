using Data.DAO;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views
{
    public partial class ProfileView : UserControl
    {
        nhanvien user;
        bool isAdmin, isUpdate = false;
        nhanvienDAO nhanvienDAO;
        List<nhanvien> nhanviens;

        public ProfileView()
        {
            InitializeComponent();
        }
        public ProfileView(nhanvien nv, bool isAdmin) : this()
        {
            nhanvienDAO = new nhanvienDAO();
            nhanviens = nhanvienDAO.GetAll();
            if (nv == null)
                user = new nhanvien()
                {
                    ma_nv = DateTime.Now.ToString("yyyyMMddhhmmss"),
                    ngay_vao_lam = DateTime.Now,
                    avatar = null
                };
            else
            {
                user = nv;
                isUpdate = true;
            }
            this.isAdmin = isAdmin;
            
            txbName.Text = user.ten_nv;
            txbAddress.Text = user.diachi;
            txbPhone.Text = user.sdt;
            cbbGender.Text = user.gioitinh;
            txbUsername.Text = user.username;
            txbPassword.Text = user.password;
            cbbRole.Text = user.chucvu;
            dtpDateBegin.Value = user.ngay_vao_lam;
            if(user.avatar != null)
                ptAvatar.BackgroundImage = Image.FromStream(new MemoryStream(user.avatar));
            if (isAdmin)
                cbbRole.Enabled = true;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG",
                Title = "Select Image"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                user.avatar = File.ReadAllBytes(openFileDialog.FileName);
                ptAvatar.BackgroundImage = Image.FromStream(new MemoryStream(user.avatar));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var nv = nhanviens.FirstOrDefault
                (n => n.ma_nv != user.ma_nv && n.username == txbUsername.Text);
            if(nv != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            user.chucvu = cbbRole.Text;
            user.diachi = txbAddress.Text;
            user.gioitinh = cbbGender.Text;
            user.ngay_vao_lam = dtpDateBegin.Value;
            user.password = txbPassword.Text;
            user.sdt = txbPhone.Text;
            user.ten_nv = txbName.Text;
            user.username = txbUsername.Text;
            try
            {
                if (isUpdate)
                    nhanvienDAO.Update(user);
                else
                    nhanvienDAO.Add(user);
                foreach (var tab in ViewModels.TabControl.tabs)
                {
                    if (tab.tabView is UserMangermentView)
                    {
                        (tab.tabView as UserMangermentView).Restart();
                        break;
                    }
                }
                MessageBox.Show("Thực hiện thành công");
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
        }
    }
}
