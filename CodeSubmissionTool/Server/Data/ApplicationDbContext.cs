using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Test>().HasData(new Test
            {
                Id = 1,
                Code = "def test():\n    print(\"hello\")",
                Language = "Python"
            });


            modelBuilder.Entity<Submission>().HasData(new Submission
            {
                Id = 1,
                Output = "",
                Result = false
            });

            modelBuilder.Entity<Question>().HasData(new Question
            {
                Id = 1,
                Description = "Given a string x, reverse and return it",
                CodeStub = "def reverse_string():"
            });


        }
    }
}
