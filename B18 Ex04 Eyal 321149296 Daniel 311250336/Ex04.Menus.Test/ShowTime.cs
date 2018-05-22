using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowTime : Ex04.Menus.Interfaces.IMenuItem
    {
        private string m_Name = "Show Time";

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public void ShowTheTime()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.Clear();
            Console.WriteLine(date.TimeOfDay.ToString());
        }

        public void Run()
        {
            ShowTheTime();
        }
    }
}
