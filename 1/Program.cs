namespace Anfängerprojekt3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Gib eine Zahl ein");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                Console.WriteLine("Deine Nummer ist positiv");

            }
            else if (number == 0)
            {
                Console.WriteLine("Deine Nummer ist Null");
            }
            else if (number <= 0)
            {
                Console.WriteLine("Deine Zahl ist negativ");
            }
            Passwordcheck();
            
        }


        static void Passwordcheck()
        {
            Console.WriteLine("Gib deinen Benutzernamen ein");
            string username = Console.ReadLine();

            Console.WriteLine("Gib dein Passwort ein");
            string password = Console.ReadLine();

            string rllogin = username + password;

            Console.WriteLine("Dein Benutzername ist: "+ username);
            Console.WriteLine("Dein Passwort ist: " + password);
            Console.WriteLine();
            Console.WriteLine("Gib deinen Benutzernamen erneut ein");
            string input_un = Console.ReadLine();
            Console.WriteLine("Gib dein Passwort erneut ein");
            string input_pw = Console.ReadLine();

            string login = input_un + input_pw;

            if (login == rllogin)
            {
                Console.WriteLine("Zugriff erlaubt");
            }
            else
            {
                Console.WriteLine("Zugriff verweigert");
            }

            
            


        }
    }
}
