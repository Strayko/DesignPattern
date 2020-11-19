using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Implementation
{
    public class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> {"Nut", "Banana", "Cup of coffe"})
            {
                Console.WriteLine($"Client: Who wants a {food}");
                
                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.WriteLine($"    {result}");
                }
                else
                {
                    Console.WriteLine($"    {food} was left untouched.");
                }
            }
        }
    }
}