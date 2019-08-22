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
    internal class AntlrBridgeTree<TValue> : BridgeBase where TValue : AstElement, new()
    {
        private Action<TValue, CommonTree, IBridgeVisitor> _action;

        public AntlrBridgeTree(IToken t, Action<TValue, CommonTree, IBridgeVisitor> action)
            : base(t, new TValue())
        {
            _action = action;
        }

        private TValue Node
        {
            get { return Element as TValue; }
        }

        public override void Accept(IBridgeVisitor visitor)
        {
            _action(Node, this, visitor);
        }
    }
}
