namespace Visitor.ClassicVisitorDoubleDispatch
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression de);
        void Visit(AdditionExpression ae);
    }
}