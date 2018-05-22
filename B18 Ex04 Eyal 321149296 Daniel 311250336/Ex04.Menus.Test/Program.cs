using System;
using System.Collections.Generic;
using System.Text;
using Method = Ex04.Menus.Delegates.MainMenu.Method;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            interfaceMenu();
            delegateMenu();
        }

        private static void interfaceMenu()
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

        private static void delegateMenu()
        {
            Ex04.Menus.Delegates.MainMenu menu1 = new Ex04.Menus.Delegates.MainMenu();
            Ex04.Menus.Delegates.SubMenu subMenu1 = new Ex04.Menus.Delegates.SubMenu("Show Date/Time");
            Ex04.Menus.Delegates.SubMenu subMenu2 = new Ex04.Menus.Delegates.SubMenu("Version and Capitals");
            menu1.AddMenu(new Method(subMenu1.Name, subMenu1.Run));
            subMenu1.AddMenu(new Method(new ShowDate().Name, new ShowDate().ShowTheDate));
            subMenu1.AddMenu(new Method(new ShowTime().Name, new ShowTime().ShowTheTime));
            menu1.AddMenu(new Method(subMenu2.Name, subMenu2.Run));
            subMenu2.AddMenu(new Method(new ShowVersion().Name, new ShowVersion().ShowTheVersion));
            subMenu2.AddMenu(new Method(new CountCapitals().Name, new CountCapitals().CountCapitalLetters));
            menu1.Show();
        }
    }
}
