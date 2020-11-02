namespace Decorator.Implementation
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}