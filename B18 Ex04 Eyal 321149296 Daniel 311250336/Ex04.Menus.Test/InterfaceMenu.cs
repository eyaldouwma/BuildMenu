using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu
    {
        public void BuildMenu()
        {
            Ex04.Menus.Interfaces.MainMenu menu1 = new Ex04.Menus.Interfaces.MainMenu();
            Ex04.Menus.Interfaces.SubMenu subMenu1 = new Ex04.Menus.Interfaces.SubMenu("Show Date/Time");
            Ex04.Menus.Interfaces.SubMenu subMenu2 = new Ex04.Menus.Interfaces.SubMenu("Version and Capitals");
            menu1.AddMenu(subMenu1);
            subMenu1.AddMenu(new ShowDate());
            subMenu1.AddMenu(new ShowTime());
            menu1.AddMenu(subMenu2);
            subMenu2.AddMenu(new ShowVersion());
            subMenu2.AddMenu(new CountCapitals());
            menu1.Show();
        }
    }
}
