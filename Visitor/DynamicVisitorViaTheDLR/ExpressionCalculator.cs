namespace Visitor.DynamicVisitorViaTheDLR
{
    public class ExpressionCalculator
    {
        public double Result;
        
        public void Visit(DoubleExpression de)
        {
            Result = de.Value;
        }
    }
}