using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class CountCapitals : Ex04.Menus.Interfaces.IMenuItem
    {
        private string m_Name = "Count Capitals";

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public void CountCapitalLetters()
        {
            string sentence;
            int capitalLetterCount = 0;

            Console.WriteLine("Please enter a sentence:");
            sentence = Console.ReadLine();
            foreach(char c in sentence)
            {
                if((c >= 'A') && (c <= 'Z'))
                {
                    capitalLetterCount++;
                }
            }

            Console.Clear();
            Console.WriteLine("The number of capital letters is: {0}", capitalLetterCount);
        }

        public void Run()
        {
            CountCapitalLetters();
        }
    }
}
