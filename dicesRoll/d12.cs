using System;
namespace dicesRoll
{
    public class d12
    {
        public void EmptyClass()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 12);
        }
    }
}
