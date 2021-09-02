using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Models
{
    public class UnitTestDto
    {
        public int Id { get; set; }

        public string Input { get; set; }

        public string Output { get; set; }
        
        public int ChallengeId { get; set; }

        public ChallengeDto ChallengeDto { get; set; }
    }
}
