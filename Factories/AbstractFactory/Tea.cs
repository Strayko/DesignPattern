using System;

namespace Factories.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice I'd prefer it with milk.");
        }
    }
}