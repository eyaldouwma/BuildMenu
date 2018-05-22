using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MainMenu, IMenuItem
    {
        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public SubMenu(string i_MenuName)
        {
            m_Name = i_MenuName;
        }

        public void Run()
        {
            this.Show();
        }
    }
}
