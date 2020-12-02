using System.Text;

namespace Visitor.ClassicVisitorDoubleDispatch
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}