using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class walutomat
    {
        private double kurs;
        public static string waluta2;

        public static void koks()
        {
            Console.WriteLine("Jaką walute wybierasz???  : //euro, dolar, zloty, frank// ");
            waluta2 = Console.ReadLine();
            while (waluta2 != "euro" & waluta2 != "dolar" & waluta2 != "zloty" & waluta2 != "frank")
            {
                Console.WriteLine("Podaj prawidłową walute: //euro, dolar, zloty, frank// ");
                waluta2 = Console.ReadLine();
            }

            waluty zloty = new waluty(1, "zloty");
            waluty euro = new waluty(4.5, "euro");
            waluty frank = new waluty(5, "frank");
            waluty dolar = new waluty(4.3, "dolar");

            switch (waluta2)
            {
                case "zloty":
                    if(menu.waluta  == waluta2)
                    {
                        WypiszWymaluj();
                        break;
                    }
                    else if(menu.waluta == "euro")
                    {
                        menu.saldo *= euro.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "frank")
                    {
                        menu.saldo *= frank.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "dolar")
                    {
                        menu.saldo *= dolar.getKurs();
                        WypiszWymaluj();
                        break;
                    }

                    break;
                case "euro":
                    if (menu.waluta == waluta2)
                    {
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "zloty") 
                    {
                        menu.saldo /= euro.getKurs();
                        WypiszWymaluj();
                        break;
                    } else if(menu.waluta == "frank")
                    {
                        menu.saldo /= frank.getKurs();
                        menu.saldo *= euro.getKurs();
                        WypiszWymaluj();
                        break;
                    }else if (menu.waluta == "dolar")
                    {
                        menu.saldo  /= dolar.getKurs();
                        menu.saldo  *= euro.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    break;
                case "dolar":
                    if(menu.waluta == waluta2)
                    {
                        WypiszWymaluj();
                        break;
                    }
                    else if(menu.waluta == "zloty")
                    {
                        menu.saldo /= dolar.getKurs();
                        WypiszWymaluj();
                        break; 
                    }
                    else if (menu.waluta == "euro")
                    {
                        menu.saldo *= euro.getKurs();
                        menu.saldo /= dolar.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "frank")
                    {
                        menu.saldo *= frank.getKurs();
                        menu.saldo *= dolar.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    break;
                case "frank":
                    if (menu.waluta == waluta2)
                    {
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "zloty")
                    {
                        menu.saldo /= frank.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "euro")
                    {
                        menu.saldo *= euro.getKurs();
                        menu.saldo /= frank.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    else if (menu.waluta == "dolar")
                    {
                        menu.saldo *= dolar.getKurs();
                        menu.saldo /= frank.getKurs();
                        WypiszWymaluj();
                        break;
                    }
                    break;
            }
        }
        public static void WypiszWymaluj()
        {
            Console.WriteLine("Sukces!");
            menu.waluta = waluta2;
            menu.Menu();
        }

    }
    
}
