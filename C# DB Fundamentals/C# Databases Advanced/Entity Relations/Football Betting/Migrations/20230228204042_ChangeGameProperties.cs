using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_FootballBetting.Migrations
{
    public partial class ChangeGameProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AwawTeamBetRate",
                table: "Games",
                newName: "AwayTeamBetRate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AwayTeamBetRate",
                table: "Games",
                newName: "AwawTeamBetRate");
        }
    }
}
