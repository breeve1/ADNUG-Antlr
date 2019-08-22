using Antlr.Runtime.Tree;
using Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParserTree.Bridge
{
    internal class BridgeVisitor : IBridgeVisitor
    {
        private CommonTree _root;
        private Ast.Program _program;

        public BridgeVisitor(CommonTree root)
        {
            _root = root;
        }

        public Ast.Program CreateAst()
        {
            var bridgeRoot = _root as BridgeBase;
            bridgeRoot.Accept(this);

            return _program;
        }

        private static string ParseLiteral(string literal)
        {
            return Regex.Replace(literal, "'", "");
        }

        private static AstElement Parent(CommonTree tree)
        {
            var parent = (CommonTree)tree.Parent;

            var bridgeParent = parent as BridgeBase;
            return bridgeParent.Element;
        }

        private void Visit(ITree tree)
        {
            var bridge = tree as BridgeBase;
            if (bridge != null)
                bridge.Accept(this);
        }

        private void VisitChildren(CommonTree tree)
        {
            Visit(tree.Children);
        }

        private void Visit(IList<ITree> trees)
        {
            if (trees != null)
            {
                foreach (var child in trees)
                    Visit(child);
            }
        }

        public void Visit(Ast.Program program, CommonTree tree)
        {
            _program = program;
            VisitChildren(tree);
        }

        public void Visit(Equal op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(NotEqual op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(GreaterThan op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(GreaterThanEqual op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(LessThan op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(LessThanEqual op, CommonTree tree)
        {
            Parent(tree).Children.Add(op);
            VisitChildren(tree);
        }

        public void Visit(OrStatement statement, CommonTree tree)
        {
            Parent(tree).Children.Add(statement);
            VisitChildren(tree);
        }

        public void Visit(AndStatement statement, CommonTree tree)
        {
            Parent(tree).Children.Add(statement);
            VisitChildren(tree);
        }

        public void Visit(WhenStatement statement, CommonTree tree)
        {
            Parent(tree).Children.Add(statement);
            VisitChildren(tree);
        }

        public void Visit(Variable variable, CommonTree tree)
        {
            Parent(tree).Children.Add(variable);
            variable.Name = tree.Text;
            VisitChildren(tree);
        }

        public void Visit(StringLiteral literal, CommonTree tree)
        {
            Parent(tree).Children.Add(literal);
            literal.Value = ParseLiteral(tree.Text);
            VisitChildren(tree);
        }

        public void Visit(IntegerLiteral literal, CommonTree tree)
        {
            Parent(tree).Children.Add(literal);
            literal.Value = int.Parse(tree.Text);
            VisitChildren(tree);
        }
    }
}
