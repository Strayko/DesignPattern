using System;

namespace TemplateMethod.Implementation
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
}