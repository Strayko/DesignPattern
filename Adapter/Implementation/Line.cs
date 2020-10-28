namespace Adapter.Implementation
{
    public class Line
    {
        public PointAdap Start, End;

        public Line(PointAdap start, PointAdap end)
        {
            Start = start;
            End = end;
        }
    }
}