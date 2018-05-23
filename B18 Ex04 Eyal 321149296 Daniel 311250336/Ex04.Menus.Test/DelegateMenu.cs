using System;
using System.Collections.Generic;
using System.Text;
using Method = Ex04.Menus.Delegates.MainMenu.Method;

namespace Ex04.Menus.Test
{
    public class DelegateMenu
    {
        public void BuildMenu()
        { 
            Ex04.Menus.Delegates.MainMenu menu1 = new Ex04.Menus.Delegates.MainMenu();
            Ex04.Menus.Delegates.SubMenu subMenu1 = new Ex04.Menus.Delegates.SubMenu("Show Date/Time");
            Ex04.Menus.Delegates.SubMenu subMenu2 = new Ex04.Menus.Delegates.SubMenu("Version and Capitals");
            menu1.AddMenu(new Method(subMenu1.Name, subMenu1.Run));
            subMenu1.AddMenu(new Method(new ShowDate().Name, ShowTheDate));
            subMenu1.AddMenu(new Method(new ShowTime().Name, ShowTheTime));
            menu1.AddMenu(new Method(subMenu2.Name, subMenu2.Run));
            subMenu2.AddMenu(new Method(new ShowVersion().Name, ShowTheVersion));
            subMenu2.AddMenu(new Method(new CountCapitals().Name, CountCapitalLetters));
            menu1.Show();
        }

        public void ShowTheDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.Clear();
            Console.WriteLine(date.Date.ToString("dd/MM/yyyy"));
        }

        public void ShowTheTime()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.Clear();
            Console.WriteLine(date.TimeOfDay.ToString());
        }

        public void ShowTheVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 18.2.4.0");
        }

        public void CountCapitalLetters()
        {
            string sentence;
            int capitalLetterCount = 0;

            Console.WriteLine("Please enter a sentence:");
            sentence = Console.ReadLine();
            foreach (char c in sentence)
            {
                if ((c >= 'A') && (c <= 'Z'))
                {
                    capitalLetterCount++;
                }
            }

            Console.Clear();
            Console.WriteLine("The number of capital letters is: {0}", capitalLetterCount);
        }
    }
}
