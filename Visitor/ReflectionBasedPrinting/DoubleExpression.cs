using System.Text;

namespace Visitor.ReflectionBasedPrinting
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            this.Value = value;
        }
    }
}