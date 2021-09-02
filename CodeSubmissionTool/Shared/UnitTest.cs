using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Shared
{
    public class UnitTest
    {
        public int Id { get; set; }

        public string Input { get; set; }

        public string Output { get; set; }

        [ForeignKey(nameof(Challenge))]
        public int ChallengeId { get; set; }

        public Challenge Challenge { get; set; }


    }
}
