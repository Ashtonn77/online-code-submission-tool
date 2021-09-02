﻿// <auto-generated />
using CodeSubmissionTool.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeSubmissionTool.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210902104043_linkedTables")]
    partial class linkedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeSubmissionTool.Shared.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeStub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Challenges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodeStub = "import sys\nsentence = sys.argv[1]\ndef checkIfPangram(sentence):",
                            Description = "A pangram is a sentence where every letter of the English alphabet appears at least once.\nGiven a string sentence containing only lowercase English letters,\n return true if sentence is a pangram, or false otherwise."
                        });
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeStub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodeStub = "def reverse_string():",
                            Description = "Given a string x, reverse and return it"
                        });
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Output")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Submissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Output = "",
                            Result = false
                        });
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "def test():\n    print(\"hello\")",
                            Language = "Python"
                        });
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.UnitTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<string>("Input")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Output")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("UnitTests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChallengeId = 1,
                            Input = "thequickbrownfoxjumpsoverthelazydog",
                            Output = "true"
                        },
                        new
                        {
                            Id = 2,
                            ChallengeId = 1,
                            Input = "leetcode",
                            Output = "false"
                        },
                        new
                        {
                            Id = 3,
                            ChallengeId = 1,
                            Input = "abcdefghijklmnopqrstuvwxyz",
                            Output = "true"
                        },
                        new
                        {
                            Id = 4,
                            ChallengeId = 1,
                            Input = "NebulaAcademy",
                            Output = "false"
                        },
                        new
                        {
                            Id = 5,
                            ChallengeId = 1,
                            Input = "",
                            Output = "false"
                        });
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.UnitTest", b =>
                {
                    b.HasOne("CodeSubmissionTool.Shared.Challenge", "Challenge")
                        .WithMany("UnitTests")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");
                });

            modelBuilder.Entity("CodeSubmissionTool.Shared.Challenge", b =>
                {
                    b.Navigation("UnitTests");
                });
#pragma warning restore 612, 618
        }
    }
}