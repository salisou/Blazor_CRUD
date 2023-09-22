using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor_CRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is some exemple for post 1. The content is very interstring and I just wanded it to be two sentences to long.", "Post 1" },
                    { 2, "This is some exemple for post 2. The content is very interstring and I just wanded it to be two sentences to long.", "Post 2" },
                    { 3, "This is some exemple for post 3. The content is very interstring and I just wanded it to be two sentences to long.", "Post 3" },
                    { 4, "This is some exemple for post 4. The content is very interstring and I just wanded it to be two sentences to long.", "Post 4" },
                    { 5, "This is some exemple for post 5. The content is very interstring and I just wanded it to be two sentences to long.", "Post 5" },
                    { 6, "This is some exemple for post 6. The content is very interstring and I just wanded it to be two sentences to long.", "Post 6" },
                    { 7, "This is some exemple for post 7. The content is very interstring and I just wanded it to be two sentences to long.", "Post 7" },
                    { 8, "This is some exemple for post 8. The content is very interstring and I just wanded it to be two sentences to long.", "Post 8" },
                    { 9, "This is some exemple for post 9. The content is very interstring and I just wanded it to be two sentences to long.", "Post 9" },
                    { 10, "This is some exemple for post 10. The content is very interstring and I just wanded it to be two sentences to long.", "Post 10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
