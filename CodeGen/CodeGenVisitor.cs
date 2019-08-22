using Ast;
using Runtime;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class CodeGenVisitor : IAstVisitor
    {
        private AstElement _program;
        private CodeCompileUnit _unit;
        private Stack<CodeDomArgs> _codeStack;

        public CodeGenVisitor(AstElement program)
        {
            _program = program;
            _codeStack = new Stack<CodeDomArgs>();
            _unit = new CodeCompileUnit();
        }

        private CodeDomArgs VisitChild(AstElement node, CodeDomArgs arg)
        {
            _codeStack.Push(arg);
            node.Accept(this);
            return _codeStack.Pop();
        }

        private CodeDomArgs VisitChild(AstElement node)
        {
            return VisitChild(node, new CodeDomArgs());
        }

        public CodeCompileUnit Generate()
        {
            _program.Accept(this);
            return _unit;
        }

        public void Visit(Program program)
        {
            var mainNamespace = new CodeNamespace("");
            mainNamespace.Imports.Add(new CodeNamespaceImport("System"));

            var type = new CodeTypeDeclaration("Code");

            var method = new CodeMemberMethod();
            method.Name = "Run";
            method.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            method.Parameters.Add(new CodeParameterDeclarationExpression(new CodeTypeReference(typeof(IArgs)), "args"));
            method.ReturnType = new CodeTypeReference(typeof(bool));
            type.Members.Add(method);

            mainNamespace.Types.Add(type);

            _unit.Namespaces.Add(mainNamespace);

            foreach(var child in _program.Children)
            {
                var args = VisitChild(child);
                method.Statements.AddRange(args.Statements);
            }

            method.Statements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression(true)));
        }

        public void Visit(Equal op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.IdentityEquality, right.Expression);
        }

        public void Visit(NotEqual op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.IdentityInequality, right.Expression);
        }

        public void Visit(GreaterThan op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.GreaterThan, right.Expression);
        }

        public void Visit(GreaterThanEqual op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.GreaterThanOrEqual, right.Expression);
        }

        public void Visit(LessThan op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.LessThan, right.Expression);
        }

        public void Visit(LessThanEqual op)
        {
            var left = VisitChild(op.Variable);
            var right = VisitChild(op.Literal);

            _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(left.Expression, CodeBinaryOperatorType.LessThanOrEqual, right.Expression);
        }

        public void Visit(OrStatement statement)
        {
            var expression = VisitChild(statement.Expression);
            _codeStack.Peek().Expression = expression.Expression;
        }

        public void Visit(AndStatement statement)
        {
            var expression = VisitChild(statement.Expression);
            
            var orStatements = ProcessBinary(statement.Statements, CodeBinaryOperatorType.BooleanOr);
            
            if (orStatements == null)
                _codeStack.Peek().Expression = expression.Expression;
            else
                _codeStack.Peek().Expression = new CodeBinaryOperatorExpression(expression.Expression, CodeBinaryOperatorType.BooleanOr, orStatements);
        }

        private CodeExpression ProcessBinary(BooleanStatement[] statements, CodeBinaryOperatorType type)
        {
            CodeExpression returnExpression;
            CodeDomArgs args;

            if (statements.Length == 0)
                returnExpression = null;
            else if (statements.Length == 1)
            {
                args = VisitChild(statements[0]);
                returnExpression = args.Expression;
            }
            else
            {
                args = VisitChild(statements[0]);
                var booleanExpression = new CodeBinaryOperatorExpression(args.Expression, type, null);
                CodeBinaryOperatorExpression left = booleanExpression;
                for (int x = 1; x < statements.Length - 1; x++)
                {
                    args = VisitChild(statements[x]);
                    var booleanOperator = new CodeBinaryOperatorExpression(args.Expression, type, null);
                    left.Right = booleanOperator;
                    left = booleanOperator;
                }

                args = VisitChild(statements[statements.Length - 1]);
                left.Right = args.Expression;

                returnExpression = booleanExpression;
            }

            return returnExpression;
        }

        public void Visit(WhenStatement statement)
        {
            var args = VisitChild(statement.Expression);

            var ifExpression = new CodeConditionStatement();
            ifExpression.Condition = args.Expression;

            var trueExpression = ProcessBinary(statement.Statements, CodeBinaryOperatorType.BooleanAnd);
            ifExpression.TrueStatements.Add(new CodeMethodReturnStatement(trueExpression));

            _codeStack.Peek().Statements.Add(ifExpression);
        }

        public void Visit(Variable variable)
        {
            _codeStack.Peek().Expression = new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("args"), variable.Name);
        }

        public void Visit(StringLiteral literal)
        {
            _codeStack.Peek().Expression = new CodePrimitiveExpression(literal.Value);
        }

        public void Visit(IntegerLiteral literal)
        {
            _codeStack.Peek().Expression = new CodePrimitiveExpression(literal.Value);
        }
    }
}
