using System.Text;

namespace Visitor.ClassicVisitorDoubleDispatch
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            this.Value = value;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            // double dispatch
            visitor.Visit(this);
        }
    }
}