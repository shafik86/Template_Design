using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Template_Design.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PbiUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Description", "Name", "PbiUrl", "Thumb" },
                values: new object[,]
                {
                    { 1, "", "Penjagaan Asset", "https://app.powerbi.com/view?r=eyJrIjoiMjYyOTNmOGMtNjUwZC00MDAwLWE5ODUtYjY1MDI0OGUxMjRlIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" },
                    { 2, "", "Data Rangkaian", "https://app.powerbi.com/view?r=eyJrIjoiMmI0YjcyZDUtZjNhYy00MGMxLWEzZDktNTkzZDE5ZDQzZDUxIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" },
                    { 3, "", "Road Accident", "https://app.powerbi.com/view?r=eyJrIjoiOTc4YmVjMGUtY2M4Ni00YTQwLWJmZTktNGQwM2I1NDE1NTZiIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Templates");
        }
    }
}
