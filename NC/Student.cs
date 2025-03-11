using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC
{
    internal class Students
    {
        List<string> ids = new List<string>();

        List<float> grades = new List<float>();
        public int Grade { get; private set; }
        public string ID { get; private set; }

        public Students(int grade, string id)
        {
            Grade = grade;
            ID = id;
        }

        public string AddInformation()
        {
            Console.WriteLine("Geben Sie Ihre ID ein");
            string inputID = (Console.ReadLine());
            if (ids.Contains(inputID))
            {
                Console.WriteLine("Diese ID existiert schon");
                AddInformation();
            }
            else
            {

                ids.Add(inputID);
                Console.WriteLine("Geben Sie Ihren NC ein");
                float inputNC = float.Parse(Console.ReadLine());
                grades.Add(inputNC);
                ID = inputID;
            }

            return ID;



        }

        public void GiveInformation()
        {
            Console.WriteLine("Geben Sie Ihre ID nochmal ein");
            string currentID = (Console.ReadLine());
            int index = ids.IndexOf(currentID);
            for (int i = 0; i != index + 1; i++)
            {

                if (index == i)
                    Console.WriteLine($"Dein NC ist:{grades[i]}");


            }

        }

        public void GiveNC()
        {

            Console.WriteLine("Der NC beträgt:" + grades.Sum());


        }

       


        

    }
}
