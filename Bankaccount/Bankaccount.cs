using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    internal class Bankaccount
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int Ammount { get; set;}

        public Bankaccount(string username, string password, int ammount)
        {
            Username = username;
            Password = password;
            Ammount = ammount;
        }

        public int Einzahlen()
        {
            Console.WriteLine("Gib den Betrag den du Einzahlen willst ein");
            int inputAmmount = int.Parse(Console.ReadLine());
            int newAmmount = inputAmmount + Ammount;
            Ammount = newAmmount;
            return Ammount;
        }

        public int Auszahlen()
        {
            Console.WriteLine("Gib den Betrag den du Auszahlen willst ein");
            int inputAmmount = int.Parse(Console.ReadLine());
            int newAmmount = Ammount - inputAmmount;
            Ammount = newAmmount;
            if (Ammount < 0)
            {
                Console.WriteLine("Achtung dein Guthaben ist negativ.");
            }
            return Ammount;
        }

        public void CreatKonto()
        {
            Console.WriteLine("Gib deine ID ein");
            Username = Console.ReadLine();
            Console.WriteLine("Gib dein Passwort ein");
            Password = Console.ReadLine();
            Console.WriteLine("Gib dein Guthaben ein");
            Ammount = int.Parse(Console.ReadLine());
        }

        public void Login()
        {
            Console.WriteLine("Gib deine ID ein");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Gib dein Passwort ein");
            string inputPassword = Console.ReadLine();

            if (inputUsername == Username && inputPassword == Password)
            {
                Console.WriteLine("Korrekt");
            }
            else
            {
                Console.WriteLine("Falsch");
                Login();
            }


        }



        
    }
}
