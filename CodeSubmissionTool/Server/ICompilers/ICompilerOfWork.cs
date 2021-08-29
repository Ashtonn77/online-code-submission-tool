using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.ICompilers
{
    public interface ICompilerOfWork
    {
        ICompiler Python { get; }
    }
}
