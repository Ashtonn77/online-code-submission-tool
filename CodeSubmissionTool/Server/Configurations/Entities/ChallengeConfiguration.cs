using CodeSubmissionTool.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Configurations.Entities
{
    public class ChallengeConfiguration : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.HasData(

                new Challenge
                {
                    Id = 1,
                    Description = "A pangram is a sentence where every letter of the English alphabet appears at least once.\nGiven a string sentence containing only lowercase English letters,\n return true if sentence is a pangram, or false otherwise.",
                    CodeStub = "import sys\nsentence = sys.argv[1]\ndef checkIfPangram(sentence):"
                }

             );
        }
    }
}
