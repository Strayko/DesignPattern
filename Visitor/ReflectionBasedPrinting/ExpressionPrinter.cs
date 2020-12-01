using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.ReflectionBasedPrinting
{
    using DictType = Dictionary<Type, Action<Expression, StringBuilder>>;
    public static class ExpressionPrinter
    {
        private static DictType actions = new DictType
        {
            [typeof(DoubleExpression)] = (e, sb) =>
            {
                var de = (DoubleExpression) e;
                sb.Append(de.Value);
            },
            [typeof(AdditionExpression)] = (e, sb) =>
            {
                var ae = (AdditionExpression) e;
                sb.Append("(");
                Print(ae.Left, sb);
                sb.Append("+");
                Print(ae.Right, sb);
                sb.Append(")");
            }
        };

        public static void Print(Expression e, StringBuilder sb)
        {
            actions[e.GetType()](e, sb);
        }

        // public static void Print(Expression e, StringBuilder sb)
        // {
        //     if (e is DoubleExpression de)
        //     {
        //         sb.Append(de.Value);
        //     }
        //     else if (e is AdditionExpression ae)
        //     {
        //         sb.Append("(");
        //         Print(ae.Left, sb);
        //         sb.Append("+");
        //         Print(ae.Right, sb);
        //         sb.Append(")");
        //     }
        // }
    }
}