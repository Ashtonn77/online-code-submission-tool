using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Models
{
    public class ChallengeDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string CodeStub { get; set; }

        public IList<UnitTestDto> UnitTests { get; set; }
    }
}
