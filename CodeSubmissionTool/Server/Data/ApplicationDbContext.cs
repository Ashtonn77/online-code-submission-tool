using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSubmissionTool.Server.Configurations.Entities;
using CodeSubmissionTool.Shared;
using Microsoft.EntityFrameworkCore;

namespace CodeSubmissionTool.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Test> Tests { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Challenge> Challenges { get; set; }

        public DbSet<UnitTest> UnitTests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Tests
            modelBuilder.Entity<Test>().HasData(new Test
            {
                Id = 1,
                Code = "def test():\n    print(\"hello\")",
                Language = "Python"
            });

            //Submissions
            modelBuilder.Entity<Submission>().HasData(new Submission
            {
                Id = 1,
                Output = "",
                Result = false
            });

            //Questions - deprecated 
            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 1,
                Description = "Given a string x, reverse and return it",
                CodeStub = "def reverse_string():"
            });


            //Challenges
            modelBuilder.ApplyConfiguration(new ChallengeConfiguration());

            //Unit Tests
            modelBuilder.ApplyConfiguration(new UnitTestConfiguration());
        }
    }
}
