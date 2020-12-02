using System.Text;

namespace Visitor.ClassicVisitorDoubleDispatch
{
    public class AdditionExpression : Expression
    {
        public Expression Left;
        public Expression Right;

        public AdditionExpression(Expression left, Expression right)
        {
            this.Left = left;
            this.Right = right;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}