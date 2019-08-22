using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public class GreaterThanEqual : BooleanExpression
    {
        public override void Accept(IAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
