using System;
using System.Collections.ObjectModel;

namespace Adapter.Implementation
{
    public class LineToPointAdapter : Collection<PointAdap>
    {
        private static int count;

        public LineToPointAdapter(Line line)
        {
            Console.WriteLine($"{++count}: Generating points for line [{line.Start.x},{line.Start.y}]-[{line.End.x},{line.End.y}]");

            int left = Math.Min(line.Start.x, line.End.x);
            int right = Math.Max(line.Start.x, line.End.x);
            int top = Math.Min(line.Start.y, line.End.y);
            int bottom = Math.Max(line.Start.y, line.End.y);
            int dx = right - left;
            int dy = line.End.y - line.Start.y;
            
            // 2:30
        }
    }
}