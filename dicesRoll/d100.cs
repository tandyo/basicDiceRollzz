using System;
namespace dicesRoll
{
    public class d100
    {
        public void EmptyClass()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 100);
        }
    }
}
