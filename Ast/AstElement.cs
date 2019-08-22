using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public abstract class AstElement
    {
        protected AstElement()
        {
            Children = new ChildCollection(this);
        }

        public ChildCollection Children { get; private set; }
        public AstElement Parent { get; set; }

        public abstract void Accept(IAstVisitor visitor);
    }
}
