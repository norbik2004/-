using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class menu
    {
        public static double saldo;
        public static string waluta = "zloty";
        public static void Menu()
        {
            string wybor;
            Console.WriteLine("------------------------");
            Console.WriteLine("Witamy w Kantorze ! \n");
            Console.WriteLine(" 1 ~~~~ Weź Udział w Loterii!!!!!!");
            Console.WriteLine(" 2 ~~~~ Sprawdz swoje Saldo!!!!!!!");
            Console.WriteLine(" 3 ~~~~ Walutomat");
            Console.WriteLine(" 4 ~~~~ Dodaj Saldo");
            Console.WriteLine(" 5 ~~~~ Narysuj Drzewo!");
            wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    loteria.loteriada();
                    break;
                case "2":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Twoje Saldo to :  " + saldo + " " + waluta);
                    Menu();
                    break;
                case "3":
                    walutomat.koks();
                    break;
                case "4":
                    dodak.Dodaj();
                    break;
                case "5":
                    Console.WriteLine("Podaj wysokość drzewa!!!");
                    int wysokosc = Convert.ToInt32(Console.ReadLine());
                    drzewko.NarysujDrzewo(wysokosc);
                    break;
            }
        }

    }
}
