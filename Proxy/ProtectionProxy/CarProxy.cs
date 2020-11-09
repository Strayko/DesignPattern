using System;

namespace Proxy.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private Driver _driver;
        private Car car = new Car();

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }

        public void Drive()
        {
            if (_driver.Age >= 16)
            {
                car.Drive();
            }
            else
            {
                Console.WriteLine("Too young");
            }
        }
    }
}