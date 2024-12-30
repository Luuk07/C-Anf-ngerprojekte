namespace C_Anfangsprojekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie fünf Werte an");
            string wertOne = Console.ReadLine();
            string wertTwo = Console.ReadLine();
            string wertThree = Console.ReadLine();
            string wertFour = Console.ReadLine();
            string wertFive = Console.ReadLine();

          
            int valueOne = int.Parse(wertOne);
            int valueTwo = int.Parse(wertTwo);
            int valueThree = int.Parse(wertThree);
            int valueFour = int.Parse(wertFour);
            int valueFive = int.Parse(wertFive);

            int[] values = {valueOne, valueTwo, valueThree, valueFour, valueFive };
            int value = 0;
            foreach (int n in values)
            {
                value += n;
                
            }
            Console.WriteLine(value);






        }
    }
}
