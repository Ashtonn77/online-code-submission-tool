using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Shared
{
    public class Challenge
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string CodeStub { get; set; }

        public virtual IList<UnitTest> UnitTests { get; set; }
    }
}
