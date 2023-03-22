using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class drzewko
    {
        public static void NarysujDrzewo(int wysokosc)
        {
            if (wysokosc < 1)
            {
                Console.WriteLine("Drzewo musi mieć wysokość większą niż zero!");
                menu.Menu();
            }

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < wysokosc - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < wysokosc / 2; i++)
            {
                for (int j = 0; j < wysokosc - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }

            Console.WriteLine();
            menu.Menu();
        }
        
    }

}
