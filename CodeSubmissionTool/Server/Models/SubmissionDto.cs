using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Models
{
    public class SubmissionDto
    {
        public int Id { get; set; }

        public string Output { get; set; }

        public bool Result { get; set; }
    }
}
