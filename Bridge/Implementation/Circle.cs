namespace Bridge.Implementation
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(_radius);
        }

        public override void Resize(float factor)
        {
            _radius *= factor;
        }
    }
}