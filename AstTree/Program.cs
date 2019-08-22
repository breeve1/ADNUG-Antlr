using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Ast;
using CodeGen;
using ParserTree.AntlrCode;
using ParserTree.Bridge;
using Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string code = @"

when [ToPractice] is 'cardiology of bob'

*[Insurance] is 'blue cross' +[Insurance] is 'blah' +[Insurance] is 'blah3'
*[DocumentCount] greater than 1
*[DocumentCount] less than 3

when [ToPractice] is 'test'
*[DocumentCount] greater than 10
            
";

            var lexer = new DslLexer(new ANTLRStringStream(code));
            var tokens = new CommonTokenStream(lexer);

            var parser = new DslParser(tokens);
            parser.TreeAdaptor = new BridgeAdapter();
            var result = parser.program();

            //Generate .dot graph. View it at http://mdaines.github.io/viz.js/
            var graphGenerator = new DotTreeGenerator();
            var dotFile = graphGenerator.ToDot(result.Tree);

            if (lexer.Errors.Count > 0)
            {
                foreach (var error in lexer.Errors)
                    Console.WriteLine(error);

                return;
            }

            if (parser.Errors.Count > 0)
            {
                foreach (var error in parser.Errors)
                    Console.WriteLine(error);

                return;
            }

            var bridge = new BridgeVisitor(result.Tree);
            var ast = bridge.CreateAst();

            var codeGen = new CodeGenVisitor(ast);
            var codeUnit = codeGen.Generate();

            //Code Gen;
            string codeString = Persist.ToCSharpSource(codeUnit);

            //Compile
            var persist = new Persist(codeUnit);
            var assembly = persist.ToAssembly();
            
            if (persist.Errors.Count > 0)
            {
                foreach (var error in persist.Errors)
                    Console.WriteLine(error);

                return;
            }

            //Run
            var instance = assembly.CreateInstance("Code");
            var method = assembly.GetType("Code").GetMethod("Run");
            var methodArgs = new Args { ToPractice = "test", Insurance = "blue cross", DocumentCount = 5 };
            var codeResult = (bool)method.Invoke(instance, new[] { methodArgs });
            Console.WriteLine(codeResult);
            
        }


        private class Args : IArgs
        {
            public string ToPractice { get; set; }
            public string Insurance { get; set; }
            public int DocumentCount { get; set; }
        }
    }
}
