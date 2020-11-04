namespace Decorator.DynamicDecoratorComposition
{
    public class Square : IShape
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }
        
        public string AsString() => $"A square with side {side}";
    }
}