using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class CodeDomArgs
    {
        public CodeDomArgs()
        {
            Statements = new CodeStatementCollection();
        }

        public CodeExpression Expression { get; set; }
        public CodeStatementCollection Statements { get; private set; }
    }
}
