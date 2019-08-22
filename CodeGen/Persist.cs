using Microsoft.CSharp;
using Runtime;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class Persist
    {
        private CodeCompileUnit _unit;

        public Persist(CodeCompileUnit unit)
        {
            _unit = unit;
            Errors = new List<string>();
        }

        public static string ToCSharpSource(CodeCompileUnit unit)
        {
            string code = string.Empty;
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            using (StringWriter writer = new StringWriter())
            {
                provider.GenerateCodeFromCompileUnit(
                  unit, writer, options);
                code = writer.ToString();
            }

            return code;
        }

        public IList<string> Errors { get; private set; }

        public Assembly ToAssembly()
        {
            var errors = new List<string>();
            Assembly generatedAssembly = null;

            String[] assemblyNames = { 
                                         "System.dll",
                                         "System.Core.dll",
                                         typeof(IArgs).Assembly.Location
                                     };

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters(assemblyNames);

            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;

            CompilerResults cr = provider.CompileAssemblyFromDom(cp, _unit);
            foreach (CompilerError compilerError in cr.Errors)
            {
                if (!compilerError.IsWarning)
                    Errors.Add(compilerError + Environment.NewLine);
            }

            if (!Errors.Any())
                generatedAssembly = cr.CompiledAssembly;

            return generatedAssembly;
        }
    }
}
