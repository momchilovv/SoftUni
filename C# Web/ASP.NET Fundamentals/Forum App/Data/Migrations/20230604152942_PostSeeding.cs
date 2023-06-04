using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ForumApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class PostSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("23ff44a7-3f9f-4a87-b327-6c85d17b1f0b"), "Let me put some extra content so the validation would be okay.", "This is the first Post" },
                    { new Guid("6b219522-f4d5-415f-b972-fe8022565b04"), "Let me put some extra content so the validation would be okay.", "This is the second Post" },
                    { new Guid("fd976b26-47e9-4f19-9e0b-cb558810daa4"), "Let me put some extra content so the validation would be okay.", "This is the third and last Post" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("23ff44a7-3f9f-4a87-b327-6c85d17b1f0b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6b219522-f4d5-415f-b972-fe8022565b04"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("fd976b26-47e9-4f19-9e0b-cb558810daa4"));
        }
    }
}
