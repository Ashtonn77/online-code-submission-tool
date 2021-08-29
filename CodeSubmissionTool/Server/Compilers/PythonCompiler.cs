using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeSubmissionTool.Server.ICompilers;

namespace CodeSubmissionTool.Server.Compilers
{
    public class PythonCompiler : ICompiler
    {
        public void CreateFile(string code, string fileName)
        {

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(code);
            }

        }

        public string ExecuteScript(string fileName, string a)
        {
            //1. create process info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Python\Python390\python.exe";
            
            //2. provide script and arguments
            var script = fileName;
            psi.Arguments = $"\"{script}\" \"{a}\"";


            //3. process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //4. Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd();
                errors = process.StandardError.ReadToEnd();
            }

            return results;
            
        }
    }
}
