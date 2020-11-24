using System;

namespace Mediator.Implementation
{
    public class Component2 : BaseComponent
    {
        public void Doc()
        {
            Console.WriteLine("Component 2 does C.");
            _mediator.Notify(this, "C");
        }

        public void Dod()
        {
            Console.WriteLine("Component 2 does D.");
            _mediator.Notify(this, "D");
        }
    }
}