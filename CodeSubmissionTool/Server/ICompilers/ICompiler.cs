using CodeSubmissionTool.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.ICompilers
{
    public interface ICompiler
    {
        void CreateFile(string c, string f);

        string ExecuteScript(string f, string a);

    }
    
}
