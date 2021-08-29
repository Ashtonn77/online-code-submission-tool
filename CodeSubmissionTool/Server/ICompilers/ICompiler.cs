using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.ICompilers
{
    public interface ICompiler
    {
        void CreateFile(string code, string fileName);

        string ExecuteScript(string fileName, string argument);

    }
    
}
