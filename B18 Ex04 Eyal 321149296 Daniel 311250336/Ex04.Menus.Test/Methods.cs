using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class MethodsClass
    {
        public void ShowTheDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.Clear();
            Console.WriteLine(date.Date.ToString());
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
