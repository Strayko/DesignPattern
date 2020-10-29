using System;
using System.Collections.Generic;
using MoreLinq;

namespace Adapter.AdapterCaching
{
    public class PointAdap
    {
        public int x, y;

        public PointAdap(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected bool Equals(PointAdap other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PointAdap) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        private static readonly List<VectorObject> vectorObjects
            = new List<VectorObject>
            {
                new Rectangle(1,1,10,10),
                new Rectangle(3,3,6,6)
            };
        
        public static void DrawPoint(PointAdap p)
        {
            Console.WriteLine(".");
        }
        
        public void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }
    }
}