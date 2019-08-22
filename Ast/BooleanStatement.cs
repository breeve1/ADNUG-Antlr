using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public abstract class BooleanStatement : AstElement
    {
        public BooleanExpression Expression
        {
            get
            {
                return Children.Where(x => x.GetType().IsSubclassOf(typeof(BooleanExpression))).Cast<BooleanExpression>().Single();
            }
        } 
    }
}
