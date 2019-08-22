using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTree.Bridge
{
    internal abstract class BridgeBase : CommonTree
    {
        protected BridgeBase(IToken t, AstElement element)
            : base(t)
        {
            Element = element;
        }

        public AstElement Element { get; private set; }
        public abstract void Accept(IBridgeVisitor visitor);
    }
}
