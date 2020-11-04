using System;

namespace Facade.Implementation
{
    // The client code works with complex subsystems through a simple
    // interface provided by the Facade. When a facade manages the lifecycle
    // of the subsystem, the client might not even know about the existence
    // of the subsystem. This approach lets you keep the complexity under
    // control.
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}