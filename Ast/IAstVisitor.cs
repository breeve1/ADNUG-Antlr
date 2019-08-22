using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public interface IAstVisitor
    {
        void Visit(Program program);

        void Visit(Equal op);
        void Visit(NotEqual op);
        void Visit(GreaterThan op);
        void Visit(GreaterThanEqual op);
        void Visit(LessThan op);
        void Visit(LessThanEqual op);

        void Visit(OrStatement statement);
        void Visit(AndStatement statement);

        void Visit(WhenStatement statement);

        void Visit(Variable variable);
        void Visit(StringLiteral literal);
        void Visit(IntegerLiteral literal);
    }
}
