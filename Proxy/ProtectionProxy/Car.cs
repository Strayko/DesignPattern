using System;

namespace Proxy.ProtectionProxy
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }
}