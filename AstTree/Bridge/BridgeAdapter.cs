using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Ast;
using ParserTree.AntlrCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTree.Bridge
{
    public class BridgeAdapter : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            if (payload != null)
            {
                if (payload.Type == DslParser.PROGRAM)
                    return new AntlrBridgeTree<Ast.Program>(payload, (node, tree, visitor) => visitor.Visit(node, tree));

                if (payload.Type == DslParser.EQUAL)
                    return new AntlrBridgeTree<Equal>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.NOT_EQUAL)
                    return new AntlrBridgeTree<NotEqual>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.GREATER_THAN)
                    return new AntlrBridgeTree<GreaterThan>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.GREATER_THAN_EQUAL)
                    return new AntlrBridgeTree<GreaterThanEqual>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.LESS_THAN)
                    return new AntlrBridgeTree<LessThan>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.LESS_THAN_EQUAL)
                    return new AntlrBridgeTree<LessThanEqual>(payload, (node, tree, visitor) => visitor.Visit(node, tree));

                if (payload.Type == DslParser.OR_STATEMENT)
                    return new AntlrBridgeTree<OrStatement>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.AND_STATEMENT)
                    return new AntlrBridgeTree<AndStatement>(payload, (node, tree, visitor) => visitor.Visit(node, tree));

                if (payload.Type == DslParser.WHEN_STATEMENT)
                    return new AntlrBridgeTree<WhenStatement>(payload, (node, tree, visitor) => visitor.Visit(node, tree));

                if (payload.Type == DslParser.VARIABLE)
                    return new AntlrBridgeTree<Variable>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.STRING_LITERAL)
                    return new AntlrBridgeTree<StringLiteral>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
                if (payload.Type == DslParser.INT)
                    return new AntlrBridgeTree<IntegerLiteral>(payload, (node, tree, visitor) => visitor.Visit(node, tree));
            }

            return new CommonTree(payload);
        }
    }
}
