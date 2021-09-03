using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSubmissionTool.Server.ICompilers;

namespace CodeSubmissionTool.Server.Compilers
{
    public class CompilerOfWork : ICompilerOfWork
    {
        private ICompiler _python;
        private ICompiler _sql;
        public ICompiler Python => _python ??= new PythonCompiler();
        public ICompiler SQL => _sql ??= new SQLCompiler();
    }
}
