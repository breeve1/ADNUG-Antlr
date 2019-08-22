using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTree.AntlrCode
{
    public partial class DslLexer : Lexer
    {
        partial void OnCreated()
        {
            Errors = new List<string>();
        }
        
        public List<string> Errors { get; private set; }

        public override void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
        {
            var header = GetErrorHeader(e);
            var error = GetErrorMessage(e, tokenNames);

            Errors.Add(string.Format("{0} : {1}", header, error));

            base.DisplayRecognitionError(tokenNames, e);
        }
    }
}
