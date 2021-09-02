using CodeSubmissionTool.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Configurations.Entities
{
    public class UnitTestConfiguration : IEntityTypeConfiguration<UnitTest>
    {
        public void Configure(EntityTypeBuilder<UnitTest> builder)
        {
            builder.HasData(

              new UnitTest
              {
                  Id = 1,
                  Input = "thequickbrownfoxjumpsoverthelazydog",
                  Output = "true",
                  ChallengeId = 1
              },
              new UnitTest
              {
                  Id = 2,
                  Input = "leetcode",
                  Output = "false",
                  ChallengeId = 1
              },
              new UnitTest
              {
                  Id = 3,
                  Input = "abcdefghijklmnopqrstuvwxyz",
                  Output = "true",
                  ChallengeId = 1
              },
              new UnitTest
              {
                  Id = 4,
                  Input = "NebulaAcademy",
                  Output = "false",
                  ChallengeId = 1
              },
              new UnitTest
              {
                  Id = 5,
                  Input = "",
                  Output = "false",
                  ChallengeId = 1
              }

              );
        }
    }
}
