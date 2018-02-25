using System;

namespace dicesRoll
{
    class actualDiceRoll
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Random rnd = new Random();
            int dice = rnd.Next(1, 100);
            Console.WriteLine("{0}", dice);
        }
    }
}
