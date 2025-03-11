namespace NC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students allStudents = new Students(0,"");
            bool run = true;

            while (run)
            {
                Console.WriteLine("1= Information hinzufügen, 2= Note bekommen, 3= Notenschnitt bekommen, 4= Programm schließen");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        allStudents.AddInformation();
                        break;
                    case 2:
                        allStudents.GiveInformation();
                        break;
                    case 3:
                        allStudents.GiveNC();
                        break;
                    case 4:
                        Console.WriteLine("Tschüß");
                        run = false;
                        break;
                }
                    
               

            }
                
            }
    }
}
