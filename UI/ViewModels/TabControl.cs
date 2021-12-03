using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Views;

namespace UI.ViewModels
{
    public class Tab
    {
        public TabHeaderStyle tabHeader;
        public Control tabView = new Control();
        public string title;
        public Tab(string title, Control view)
        {
            this.title = title;
            tabHeader = new TabHeaderStyle(title);            
            tabView = view;
            tabView.Dock = DockStyle.Fill;
            tabHeader.btnCloseTab.Click +=
                new EventHandler(delegate
                {
                    TabControl.CloseTab(this);
                });
            tabHeader.lblTitle.Click +=
                new EventHandler(delegate
                {
                    TabControl.FocusTab(this);
                });
        }

    }
    public static class TabControl
    {
        static TabControlView tabControl;
        public static List<Tab> tabs;
        public static void Init(TabControlView tabCtrl)
        {
            tabs = new List<Tab>();
            tabControl = tabCtrl;
        }
        public static void OpenTab(Tab tab)
        {
            //if (tab.viewModel is CreateCardViewModel)
            //{
            //    tab.tabView = new CreateCardView();
            //    tab.viewModel = new CreateCardViewModel(tab.tabView);
            //}
            //if (tab.viewModel is BorrowBookViewModel)
            //{
            //    tab.tabView = new BorrowBookView();
            //    tab.viewModel = new BorrowBookViewModel(tab.tabView);
            //}
            //if (tab.viewModel is ReturnBookViewModel)
            //{
            //    tab.tabView = new ReturnBookView();
            //    tab.viewModel = new ReturnBookViewModel(tab.tabView);
            //}
            tabControl.Visible = true;
            var tb = tabs.FirstOrDefault(t => t.title == tab.title);
            if (tb != null)
            {
                FocusTab(tb);
                return;
            }
            tab.tabHeader.Location = new Point(tabs.Count * 150, 0);
            tabs.Add(tab);
            tabControl.pnlHeader.Controls.Add(tab.tabHeader);
            tabControl.pnlView.Controls.Add(tab.tabView);
            FocusTab(tab);
        }
        public static void FocusTab(Tab tab)
        {
            foreach (var t in tabs)
            {
                t.tabView.Visible = false;
                t.tabHeader.BackColor = Color.FromArgb(187, 128, 130);
            }
            tab.tabHeader.BackColor = Color.FromArgb(243, 145, 137);
            tab.tabView.Visible = true;
        }
        public static void CloseTab(Tab tab)
        {
            tabControl.pnlHeader.Controls.Remove(tab.tabHeader);
            tabControl.pnlView.Controls.Remove(tab.tabView);
            var idx = tabs.IndexOf(tab);
            tabs.Remove(tab);
            if (tabs.Count == 0)
            {
                tabControl.Visible = false;
                return;
            }
            FocusTab(tabs[Math.Min(idx, tabs.Count - 1)]);
            Reload();
        }
        static void Reload()
        {
            for (int i = 0; i < tabs.Count; ++i)
            {
                tabs[i].tabHeader.Location = new Point(i * 150, 0);
            }            
        }
    }
}
