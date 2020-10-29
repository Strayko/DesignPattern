using System;

namespace Adapter.AdapterCaching
{
    public class Line
    {
        public PointAdap Start, End;

        public Line(PointAdap start, PointAdap end)
        {
            Start = start;
            End = end;
        }

        protected bool Equals(Line other)
        {
            return Equals(Start, other.Start) && Equals(End, other.End);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Line) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
    }
}