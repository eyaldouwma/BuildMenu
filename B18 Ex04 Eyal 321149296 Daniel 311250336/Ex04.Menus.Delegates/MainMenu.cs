using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        protected string m_Name = "Main Menu";

        public delegate void subMenusAndFunctions();

        public struct Method
        {
            private string m_MethodName;

            public string Name
            {
                get
                {
                    return m_MethodName;
                }
            }

            private subMenusAndFunctions m_TheMethod;

            public subMenusAndFunctions TheMethod
            {
                get
                {
                    return m_TheMethod;
                }
            }

            public Method(string i_MethodName, subMenusAndFunctions i_TheMethod)
            {
                m_MethodName = i_MethodName;
                m_TheMethod = i_TheMethod;
            }
        }

        public List<Method> m_MenuItems = new List<Method>();
       
        public void AddMenu(Method i_MenuToAdd)
        {
            m_MenuItems.Add(i_MenuToAdd);
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
                    m_MenuItems[userChoice].TheMethod.Invoke();
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

                if ((userChoice < 0) || (userChoice > m_MenuItems.Count))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, please choose an option from the range");
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
            foreach (Method method in m_MenuItems)
            {
                Console.WriteLine("{0}) {1}", menuNumber, method.Name);
                menuNumber++;
            }
        }
    }
}
