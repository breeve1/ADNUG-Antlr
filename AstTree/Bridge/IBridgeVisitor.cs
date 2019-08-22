using Antlr.Runtime.Tree;
using Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTree.Bridge
{
    internal interface IBridgeVisitor
    {
        void Visit(Ast.Program program, CommonTree tree);

        void Visit(Equal op, CommonTree tree);
        void Visit(NotEqual op, CommonTree tree);
        void Visit(GreaterThan op, CommonTree tree);
        void Visit(GreaterThanEqual op, CommonTree tree);
        void Visit(LessThan op, CommonTree tree);
        void Visit(LessThanEqual op, CommonTree tree);

        void Visit(OrStatement statement, CommonTree tree);
        void Visit(AndStatement statement, CommonTree tree);

        void Visit(WhenStatement statement, CommonTree tree);

        void Visit(Variable variable, CommonTree tree);
        void Visit(StringLiteral literal, CommonTree tree);
        void Visit(IntegerLiteral literal, CommonTree tree);
    }
}
