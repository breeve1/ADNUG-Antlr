using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public abstract class BooleanExpression : AstElement
    {
        public Variable Variable
        {
            get
            {
                return Children.Where(x => x.GetType() == typeof(Variable)).Cast<Variable>().Single();
            }
        }
        
        public Literal Literal
        {
            get
            {
                return Children.Where(x => x.GetType().IsSubclassOf(typeof(Literal))).Cast<Literal>().Single();
            }
        }
    }
}
