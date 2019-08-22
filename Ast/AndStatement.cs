using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public class AndStatement : BooleanStatement
    {
        public OrStatement[] Statements
        {
            get
            {
                return Children.Where(x => x.GetType() == typeof(OrStatement)).Cast<OrStatement>().ToArray();
            }
        }
   
        public override void Accept(IAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
