using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public class WhenStatement : AstElement
    {
        public BooleanExpression Expression
        { 
            get
            {
                return Children.Where(x => x.GetType().IsSubclassOf(typeof(BooleanExpression))).Cast<BooleanExpression>().Single();
            }
        } 

        public AndStatement[] Statements
        {
            get 
            {
                return Children.Where(x => x.GetType() == typeof(AndStatement)).Cast<AndStatement>().ToArray();
            }
        }

        public override void Accept(IAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

