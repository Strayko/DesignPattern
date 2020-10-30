namespace Bridge.Implementation
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}