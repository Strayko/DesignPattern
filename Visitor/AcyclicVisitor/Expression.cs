namespace Visitor.AcyclicVisitor
{
    // 3 - DoubleExpression
    // (1+2) (1+(2+3)) AdditionExpression
    public abstract class Expression
    {
        public virtual void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<Expression> typed)
                typed.Visit(this);
        }
    }
}