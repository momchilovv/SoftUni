using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class AddingComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUsers_AspNetUsers_CollectorId",
                table: "IdentityUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUsers_Books_BookId",
                table: "IdentityUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUsers",
                table: "IdentityUsers");

            migrationBuilder.RenameTable(
                name: "IdentityUsers",
                newName: "IdentityUserBooks");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUsers_BookId",
                table: "IdentityUserBooks",
                newName: "IX_IdentityUserBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserBooks",
                table: "IdentityUserBooks",
                columns: new[] { "CollectorId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserBooks_AspNetUsers_CollectorId",
                table: "IdentityUserBooks",
                column: "CollectorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserBooks_Books_BookId",
                table: "IdentityUserBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserBooks_AspNetUsers_CollectorId",
                table: "IdentityUserBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserBooks_Books_BookId",
                table: "IdentityUserBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserBooks",
                table: "IdentityUserBooks");

            migrationBuilder.RenameTable(
                name: "IdentityUserBooks",
                newName: "IdentityUsers");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserBooks_BookId",
                table: "IdentityUsers",
                newName: "IX_IdentityUsers_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUsers",
                table: "IdentityUsers",
                columns: new[] { "CollectorId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUsers_AspNetUsers_CollectorId",
                table: "IdentityUsers",
                column: "CollectorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUsers_Books_BookId",
                table: "IdentityUsers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
