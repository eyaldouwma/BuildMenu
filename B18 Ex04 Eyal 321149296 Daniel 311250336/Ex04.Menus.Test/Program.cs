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
            InterfaceMenu interfaceMenu = new Test.InterfaceMenu();
            interfaceMenu.BuildMenu();
            DelegateMenu delegateMenu = new Test.DelegateMenu();
            delegateMenu.BuildMenu();
        }
    }
}
