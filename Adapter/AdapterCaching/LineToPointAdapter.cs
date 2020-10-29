using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Adapter.AdapterCaching
{
    public class LineToPointAdapter : IEnumerable<PointAdap>
    {
        private static int count;
        
        private static Dictionary<int, List<PointAdap>> cache = new Dictionary<int, List<PointAdap>>();

        public LineToPointAdapter(Line line)
        {
            var hash = line.GetHashCode();
            if (cache.ContainsKey(hash)) return;
            
            Console.WriteLine($"{++count}: Generating points for line [{line.Start.x},{line.Start.y}]-[{line.End.x},{line.End.y}]");
            
            var points = new List<PointAdap>();

            int left = Math.Min(line.Start.x, line.End.x);
            int right = Math.Max(line.Start.x, line.End.x);
            int top = Math.Min(line.Start.y, line.End.y);
            int bottom = Math.Max(line.Start.y, line.End.y);
            int dx = right - left;
            int dy = line.End.y - line.Start.y;

            if (dx == 0)
            {
                for (int y = top; y < bottom; y++)
                {
                    points.Add(new PointAdap(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x < right; x++)
                {
                    points.Add(new PointAdap(x, top));
                }
            }

            cache.Add(hash, points);
        }

        public IEnumerator<PointAdap> GetEnumerator()
        {
            return cache.Values.SelectMany(x => x).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}