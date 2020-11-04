namespace Decorator.DynamicDecoratorComposition
{
    public class ColoredShape : IShape
    {
        private IShape shape;
        private string color;

        public ColoredShape(IShape shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }
        
        public string AsString() => $"{shape.AsString()} has the color {color}";
    }
}