using System;
using MenuBiblioteka;

namespace CompositeTest
{
    internal class MenuTest
    {
        static void Main(string[] args)
        {
            Menu glowne = new("glowne", "http://glowne.menu/menu");
            Menu podmenu = new("podmenu", "http://glowne.menu/menu/pod");
            MenuItem strona = new("strona", "http://glowne.menu/menu/strona");
            MenuItem podstrona = new("podstrona", "http://glowne.menu/menu/pod/podstrona");
            MenuItem drugapodstrona = new("drugapodstrona", "http://glowne.menu/menu/pod/druga");

            glowne.DisplayMenu();
            Console.WriteLine("---");

            glowne.Add(strona);
            glowne.Add(podmenu);
            strona.Add(podstrona);
            podmenu.Add(podstrona);
            podmenu.Add(drugapodstrona);
            glowne.DisplayMenu();
            Console.WriteLine("---");
        }
    }
}
