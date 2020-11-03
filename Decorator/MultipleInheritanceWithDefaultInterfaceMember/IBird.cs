using System;

namespace Decorator.MultipleInheritanceWithDefaultInterfaceMember
{
    public interface IBird : ICreature
    {
        void Fly()
        {
            if (Age > 10)
            {
                Console.WriteLine("I am flying");
            }
        }
    }
}