using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
// mialo byc dodaj ale kliknalem k i nie chce mi sie zmieniac
namespace łóóóóóó
{
    internal class dodak
    {
        public static void Dodaj()
        {
            int wynik = 0;
            int blad = 0;
            Random losowaLiczba = new Random();
            int dlugosc = losowaLiczba.Next(0,41);
            char[] tablica = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'q', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for(int i = 0; i < dlugosc; i++)
            {
                int liczba = losowaLiczba.Next(0, tablica.Length - 1);
                Console.WriteLine("Wpisz to co sie wyswietli "+ dlugosc +" razy aby dodac talary do konta");
                Console.WriteLine(tablica[liczba]);
                char wpisane = Convert.ToChar(Console.ReadLine());
                if (wpisane == tablica[liczba])
                {
                    wynik++;
                    Console.WriteLine("Pieknie! wpisales juz  " + wynik);
                }
                else
                {
                    Console.WriteLine("Sprobuj jeszcze raz. 3 błedy i koniec gry");
                    blad++;

                }
                if (blad == 3)
                {
                    Console.WriteLine("PAPA");
                    menu.Menu();
                }
               

            }
           
                Console.WriteLine("DODANO HAJS");
                menu.saldo += 1000;
           
            menu.Menu();
        }

        
        
       
            

        
    }
}
