using Microsoft.EntityFrameworkCore.Migrations;

namespace webproject.Migrations
{
    public partial class ver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YaziTurus",
                columns: table => new
                {
                    Yazıid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YaziTurus", x => x.Yazıid);
                });

            migrationBuilder.CreateTable(
                name: "Yazis",
                columns: table => new
                {
                    Yid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YaziAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazıid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazis", x => x.Yid);
                    table.ForeignKey(
                        name: "FK_Yazis_YaziTurus_Yazıid",
                        column: x => x.Yazıid,
                        principalTable: "YaziTurus",
                        principalColumn: "Yazıid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yazis_Yazıid",
                table: "Yazis",
                column: "Yazıid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yazis");

            migrationBuilder.DropTable(
                name: "YaziTurus");
        }
    }
}
