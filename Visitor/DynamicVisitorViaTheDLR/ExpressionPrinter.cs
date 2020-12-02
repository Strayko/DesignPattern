using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.DynamicVisitorViaTheDLR
{
   public class ExpressionPrinter
   {
      public void Print(AdditionExpression ae, StringBuilder sb)
      {
         sb.Append("(");
         Print((dynamic)ae.Left, sb);
         sb.Append("+");
         Print((dynamic)ae.Right, sb);
         sb.Append(")");
      }

      public void Print(DoubleExpression de, StringBuilder sb)
      {
         sb.Append(de.Value);
      }
   }
}