using System;

namespace Decorator.MultipleInheritanceWithDefaultInterfaceMember
{
    public interface ILizard : ICreature
    {
        void Crawl()
        {
            if (Age < 10)
            {
                Console.WriteLine("I am crawling");
            }
        }
    }
}