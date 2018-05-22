using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        protected string m_Name = "Main Menu";

        private List<IMenuItem> m_Menus = new List<IMenuItem>();

        public void AddMenu(IMenuItem i_MenuToAdd)
        {
            m_Menus.Add(i_MenuToAdd);
        }

        public void Show()
        {
            int userChoice = 1;
            Console.Clear();

            do
            {
                printMenu();
                userChoice = parsingValidity();
                if ((userChoice != -1) && (userChoice != 0))
                {
                    userChoice--; ////to get to the correct index in the list.
                    m_Menus[userChoice].Run();
                    userChoice = -1;
                }
            }
            while (userChoice != 0);

            Console.Clear();
        }

        private int parsingValidity()
        {
            int userChoice;

            try
            {
                userChoice = int.Parse(Console.ReadLine());

                if ((userChoice < 0) || (userChoice > m_Menus.Count))
                {
                    userChoice = -1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
                userChoice = -1;
            }

            return userChoice;
        }

        private void printMenu()
        {
            int menuNumber;

            Console.WriteLine(m_Name);
            if (this is SubMenu)
            {
                Console.WriteLine("0) Back");
            }
            else
            {
                Console.WriteLine("0) Exit");
            }

            menuNumber = 1;
            foreach (IMenuItem m in m_Menus)
            {
                Console.WriteLine("{0}) {1}", menuNumber, m.Name);
                menuNumber++;
            }
        }
    }
}
