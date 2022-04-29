using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentExample.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartId = table.Column<int>(type: "int", nullable: false),
                    DepartmentDepartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Departments_DepartmentDepartId",
                        column: x => x.DepartmentDepartId,
                        principalTable: "Departments",
                        principalColumn: "DepartId");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Muhasebe" },
                    { 2, "Satın Alma" },
                    { 3, "Müdür" },
                    { 4, "Müdür Yardımcısı" },
                    { 5, "Danışma" },
                    { 6, "Sekreter" }
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelId", "City", "DepartId", "DepartmentDepartId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Trabzon", 3, null, "Mikdat", "Gürses" },
                    { 2, "Rize", 4, null, "Bilge", "Yılmaz" },
                    { 3, "Samsun", 1, null, "Yalçın", "Uzun" },
                    { 4, "Sivas", 2, null, "Dilara", "İzibüyük" },
                    { 5, "Sinop", 5, null, "Furkan", "Elmas" },
                    { 6, "Erzincan", 5, null, "Enes", "Akpınar" },
                    { 7, "Muş", 6, null, "Burak", "Kapıcı" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmentDepartId",
                table: "Personels",
                column: "DepartmentDepartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
