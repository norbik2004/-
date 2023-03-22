using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class lotto
    {
        public static void Graj()
        {
            menu.saldo -= 100;
            if(menu.saldo < 100)
            {
                Console.WriteLine("Niewystarczające środki!");
                menu.Menu();
            }
            Console.WriteLine("Witaj w grze Lotto!");

            int[] wylosowaneLiczby = LosujLiczby();
            int[] wybraneLiczby = WybierzLiczby();

            int trafioneLiczby = SprawdzWynik(wylosowaneLiczby, wybraneLiczby);

            Console.WriteLine("Wylosowane liczby to:");
            foreach (int liczba in wylosowaneLiczby)
            {
                Console.Write(liczba + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Wybrałeś następujące liczby:");
            foreach (int liczba in wybraneLiczby)
            {
                Console.Write(liczba + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Trafiłeś " + trafioneLiczby + " liczb!");

            if (trafioneLiczby == 6)
            {
                Console.WriteLine("Gratulacje, wygrałeś Jackpot!");
                menu.saldo += 1000000;
                menu.Menu();
            }
            else if (trafioneLiczby >= 3)
            {
                Console.WriteLine("Gratulacje, wygrałeś nagrodę!");
                menu.saldo += 100000;
                menu.Menu();
            }
            else
            {
                Console.WriteLine("Niestety, tym razem przegrałeś.");
                menu.Menu();
            }
        }

        private static int[] LosujLiczby()
        {
            int[] liczby = new int[6];
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                int liczba;
                do
                {
                    liczba = rand.Next(1, 50);
                } while (Array.IndexOf(liczby, liczba) != -1);

                liczby[i] = liczba;
            }

            Array.Sort(liczby);

            return liczby;
        }

        private static int[] WybierzLiczby()
        {
            int[] liczby = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Podaj " + (i + 1) + ". liczbę z zakresu 1-49: ");
                while (!int.TryParse(Console.ReadLine(), out liczby[i]) || liczby[i] < 1 || liczby[i] > 49)
                {
                    Console.WriteLine("Błędna wartość, podaj liczbę z zakresu 1-49!");
                    Console.Write("Podaj " + (i + 1) + ". liczbę z zakresu 1-49: ");
                }
            }

            Array.Sort(liczby);

            return liczby;
        }

        private static int SprawdzWynik(int[] wylosowaneLiczby, int[] wybraneLiczby)
        {
            int trafioneLiczby = 0;

            foreach (int liczba in wybraneLiczby)
            {
                if (Array.IndexOf(wylosowaneLiczby, liczba) != -1)
                {
                    trafioneLiczby++;
                }
            }

            return trafioneLiczby;
        }
    }
}

