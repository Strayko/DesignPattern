using System;
using System.Collections.Generic;

namespace Adapter.Implementation
{
    public class PointAdap
    {
        public int x, y;

        public PointAdap(int x, int y)
        {
            this.x = x;
            this.y = y;
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
    }
}