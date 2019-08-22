using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public class Program : AstElement
    {
        public WhenStatement[] WhenStatements
        {
            get
            {
                return Children.Where(x => x.GetType() == typeof(WhenStatement)).Cast<WhenStatement>().ToArray();
            }
        }

        public override void Accept(IAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
