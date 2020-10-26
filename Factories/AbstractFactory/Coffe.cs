using System;

namespace Factories.AbstractFactory
{
    internal class Coffe : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}