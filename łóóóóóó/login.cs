using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace łóóóóóó
{
    internal class login
    {
        private string username;
        private string password;

        public login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        public static void Loguj()
        {
            Console.WriteLine("        KantUwU         ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Załóż Konto !");
            Console.WriteLine("Podaj nazwę użytkownika: ");
            Console.WriteLine("------------------------");
            string username = Console.ReadLine();
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();
            Console.WriteLine("------------------------");

            bool usernamegit = WalidujNazweUzytkownika(username);
            bool passwordgit = WalidujHaslo(password);
            bool takiesame = CzyTakieSame(username, password);

            if (usernamegit && passwordgit && takiesame)
            {
                Console.WriteLine("Pomyślnie założone Konto!!! ");
                Console.WriteLine("------------------------");
                Console.WriteLine("Zaloguj sie ! ");
                string username2;
                string password2;
                Console.WriteLine("Podaj Login!");
                username2 = Console.ReadLine();
                Console.WriteLine("Podaj Hasło!");
                password2 = Console.ReadLine(); 
                while(username2 != username || password2 != password)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Niepoprawne Dane!");
                    Console.WriteLine("Podaj Login!");
                    username2 = Console.ReadLine();
                    Console.WriteLine("Podaj Hasło!");
                    password2 = Console.ReadLine();
                    
                }
                menu.saldo = 1000;
                menu.Menu();
                
            }
            else
            {
                Console.WriteLine("------------------------");

                Loguj();
            }
           
        }
        public static bool WalidujNazweUzytkownika(string username)
        {
            if (username.Length == 0 || username.Any(char.IsDigit))
            {
                Console.WriteLine("Nieprawidłowa nazwa użytkownika. Nazwa użytkownika nie może zawierać cyfr.");
                
                return false;
            }

            return true;
        }

        public static bool WalidujHaslo(string password)
        {
            if (password.Length < 5)
            {
                Console.WriteLine("Nieprawidłowe hasło. Hasło musi mieć co najmniej 5 znaków.");
                
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Nieprawidłowe hasło. Hasło musi mieć co najmniej 1 wielką literę.");
                return false;
            }

            return true;
        }

        public static bool CzyTakieSame(string username, string password)
        {
            if (password == username)
            {
                Console.WriteLine("Login i hasło nie mogą być takie same");
                return false;
            }else
            {
                return true;
            }
        }
    }
}
