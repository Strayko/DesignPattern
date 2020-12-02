using System.Text;

namespace Visitor.DynamicVisitorViaTheDLR
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