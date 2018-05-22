using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowVersion : Ex04.Menus.Interfaces.IMenuItem
    {
        private string m_Name = "Show Version";

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public void ShowTheVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 18.2.4.0");
        }

        public void Run()
        {
            ShowTheVersion();
        }
    }
}
