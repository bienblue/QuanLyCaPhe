using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Views;

namespace UI.ViewModels
{
    public class NavItem
    {
        public string itemName { get; set; }
        public NavItemStyle navItem { get; set; }
        public Control view { get; set; }
    }
    public static class NavControl
    {
        public static List<NavItem> navItems;
        public static void Init(nhanvien user)
        {
            navItems = new List<NavItem>();
            if(user.chucvu == "Quản lý")
            {
                navItems.Add(new NavItem()
                {
                    itemName = "Order",
                    navItem = new NavItemStyle("Order"),
                    view = new OrderView(user)
                });
                navItems.Add(new NavItem()
                {
                    itemName = "Thanh toán",
                    navItem = new NavItemStyle("Thanh toán"),
                    view = new PayView()
                });
                navItems.Add(new NavItem()
                {
                    itemName = "Doanh thu",
                    navItem = new NavItemStyle("Doanh thu"),
                    view = new RevenueView()
                });
                navItems.Add(new NavItem()
                {
                    itemName = "Quản lý nhân viên",
                    navItem = new NavItemStyle("Quản lý nhân viên"),
                    view = new UserMangermentView()
                });
                navItems.Add(new NavItem()
                {
                    itemName = "Chỉnh sửa Menu",
                    navItem = new NavItemStyle("Chỉnh sửa Menu"),
                    view = new EditMenuView()
                });
            }
            else
            {
                navItems.Add(new NavItem()
                {
                    itemName = "Order",
                    navItem = new NavItemStyle("Order"),
                    view = new OrderView(user)
                });
                navItems.Add(new NavItem()
                {
                    itemName = "Thanh toán",
                    navItem = new NavItemStyle("Thanh toán"),
                    view = new PayView()
                });
            }
            foreach(var nav in navItems)
            {
                nav.navItem.btnItem.Click += new EventHandler(delegate
                {
                    TabControl.OpenTab(new Tab(nav.itemName, nav.view));
                });
            }
        }
    }
}
