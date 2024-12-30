namespace Bankaccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
           
            
            Bankaccount myBankaccount = new Bankaccount("", "", 0);
            myBankaccount.CreatKonto();

            while (run) 
            {
                Console.WriteLine("1=Einzahlen, 2= Auszahlen, 3= Anzeigen, 4 = Ausloggen, 5= Programm schließen");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        myBankaccount.Einzahlen();
                        break;
                    case 2:
                        myBankaccount.Auszahlen();
                        break;
                    case 3:
                        Console.WriteLine(myBankaccount.Ammount);
                        break;
                    case 4:
                        myBankaccount.Login();
                        break;
                    case 5:
                        Console.WriteLine("Tschüß");
                        run = false;
                        break;

                        
                }

            }
            
            
        }
    }
}
