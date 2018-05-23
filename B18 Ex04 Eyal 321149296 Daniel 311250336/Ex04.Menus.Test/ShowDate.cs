using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowDate : Ex04.Menus.Interfaces.IMenuItem
    {
        private string m_Name = "Show Date";
        
        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public void ShowTheDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.Clear();
            Console.WriteLine(date.Date.ToString("dd/MM/yyyy"));
        }

        public void Run()
        {
            ShowTheDate();
        }
    }
}
