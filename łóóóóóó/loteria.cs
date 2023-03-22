using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class loteria
    {
        
       public static void loteriada()
        {
            string knur;
            Console.WriteLine("Witamy w Loterii!!!");
            Console.WriteLine("1 ~~~ RULETKA");
            Console.WriteLine("2 ~~~~ LOTTO");
            Console.WriteLine("9 ~~~ Menu");
            knur = Console.ReadLine();  
            switch (knur)
            {
                case "1":
                    Ruletka();
                    break;
                case "2":
                    lotto.Graj();
                    break;
                case "9":
                    menu.Menu();
                    break;
            }

        }

        public static void Ruletka()
        {
            int obstawienie;
            string wybor;
            Console.WriteLine("Wpisz ile chcesz obstawic!!!!");
            obstawienie = Convert.ToInt32(Console.ReadLine());
            while(obstawienie > menu.saldo)
            {
                Console.WriteLine("Za duża stawka!!! Twoje obecne saldo to:  " + menu.saldo);
            }
            menu.saldo = menu.saldo - obstawienie;

            Console.WriteLine("Na co chcesz obstawic?????   //czarne, czerwone, zielone//");
            wybor = Console.ReadLine();

            while(wybor !="czarne" & wybor!="czerwone" & wybor != "zielone")
            {
                Console.WriteLine("Niepoprawny wybor");
                Console.WriteLine("Na co chcesz obstawic?????   //czarne, czerwone, zielone//");
                wybor = Console.ReadLine();
            }

            Random losowaLiczba = new Random();
            int liczba = losowaLiczba.Next(0, 37); 

            if (liczba == 0)
            {
                Console.WriteLine("Kula wpadła na zielone zero!");
                if (wybor == "zielone")
                {
                    Console.WriteLine("WYGRALES!");
                    menu.saldo = menu.saldo + obstawienie * 14;
                }
                else
                {
                    Console.WriteLine("dupa.....");
                }
                loteria.loteriada();
            }
            else if (liczba % 2 == 0)
            {
                Console.WriteLine("Kula wpadła na czerwone: {0}", liczba);
                if(wybor == "czerwone")
                {
                    Console.WriteLine("WYGRALES!");
                    menu.saldo = menu.saldo + obstawienie * 2;
                }
                else
                {
                    Console.WriteLine("dupa.....");
                }
                loteria.loteriada();
            }
            else
            {
                Console.WriteLine("Kula wpadła na czarne: {0}", liczba);
                if (wybor == "czarne")
                {
                    Console.WriteLine("WYGRALES!");
                    menu.saldo = menu.saldo + obstawienie * 2;
                }
                else
                {
                    Console.WriteLine("dupa.....");
                }
                loteria.loteriada();
            }
        }



    }
}
