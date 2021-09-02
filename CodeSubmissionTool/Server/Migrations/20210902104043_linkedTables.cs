using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeSubmissionTool.Server.Migrations
{
    public partial class linkedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeStub = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChallengeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitTests_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "CodeStub", "Description" },
                values: new object[] { 1, "import sys\nsentence = sys.argv[1]\ndef checkIfPangram(sentence):", "A pangram is a sentence where every letter of the English alphabet appears at least once.\nGiven a string sentence containing only lowercase English letters,\n return true if sentence is a pangram, or false otherwise." });

            migrationBuilder.InsertData(
                table: "UnitTests",
                columns: new[] { "Id", "ChallengeId", "Input", "Output" },
                values: new object[,]
                {
                    { 1, 1, "thequickbrownfoxjumpsoverthelazydog", "true" },
                    { 2, 1, "leetcode", "false" },
                    { 3, 1, "abcdefghijklmnopqrstuvwxyz", "true" },
                    { 4, 1, "NebulaAcademy", "false" },
                    { 5, 1, "", "false" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitTests_ChallengeId",
                table: "UnitTests",
                column: "ChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitTests");

            migrationBuilder.DropTable(
                name: "Challenges");
        }
    }
}
