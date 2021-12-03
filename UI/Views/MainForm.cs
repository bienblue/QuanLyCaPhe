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
using UI.ViewModels;

namespace UI.Views
{
    public partial class MainForm : Form
    {
        nhanvien user;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(nhanvien user) : this()
        {
            this.user = user;
            Icon = Icon.FromHandle(Properties.Resources.icons8_java_100.GetHicon());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NavControl.Init(user);
            lblUser.Text = user.username;
            TabControlView tabControlView = new TabControlView() {Visible = false, Dock = DockStyle.Fill};
            
            pnlContent.Controls.Add(tabControlView);
            ViewModels.TabControl.Init(tabControlView);
            foreach(var nav in NavControl.navItems)
            {
                pnlNav.Controls.Add(nav.navItem);
            }
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ViewModels.TabControl.OpenTab(new Tab(user.username, new ProfileView(user, (user.chucvu == "Quản lý"))));
        }
    }
}
