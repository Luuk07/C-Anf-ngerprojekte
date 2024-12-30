using System.ComponentModel;
using System.ComponentModel.Design;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] todolist = new string[10];
            bool run = true;



            while (run)
            {
               
                   Console.WriteLine("Was willst du ? 'Add','Delete', 'Quit'");
                   string input = Console.ReadLine().ToLower();

                   if (input == "add")
                   {
                        Add(todolist);
                   }
                   else if (input == "delete")
                   {
                        Delete();

                   }
                   else if (input == "quit")
                   {
                        run = false;
                   }
                

                static void Add(string[] todolist)
                {



                     Console.WriteLine("Wie viele ToDos hast du bereits?");
                     int start = int.Parse(Console.ReadLine());

                     Console.WriteLine("Wie viele ToDos willst du insgesamt haben");
                     int counter = int.Parse(Console.ReadLine());
                     int[] counterlenght = new int[counter];


                     for (int i = start; i < counterlenght.Length; i++)
                     {
                            Console.WriteLine("Gib dein ToDo ein");
                            string todo = Console.ReadLine();
                            todolist[i] = todo;
                            

                    }
                     counter = 0;
                     Console.WriteLine("Deine ToDos sind:");
                     View(ref counterlenght, todolist);

                     return;
                     
     

                }

                static void View(ref int [] länge, string[] todolist)
                {
                    for (int i = 0; i < länge.Length; i++)
                    {
                        Console.WriteLine(todolist[i]);

                    }

                }
                
                static void Delete()
                { 
                   
                }
                

            }
            Console.WriteLine("Tschüss");
        }
    }
}
