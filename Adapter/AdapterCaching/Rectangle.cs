namespace Adapter.AdapterCaching
{
    public class Rectangle : VectorObject
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Add(new Line(new PointAdap(x, y), new PointAdap(x + width, y)));
            Add(new Line(new PointAdap(x + width, y), new PointAdap(x + width, y + height)));
            Add(new Line(new PointAdap(x, y), new PointAdap(x, y + height)));
            Add(new Line(new PointAdap(x, y + height), new PointAdap(x + width, y + height)));
        }
    }
}