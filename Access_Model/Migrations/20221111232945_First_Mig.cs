using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Access_Model.Migrations
{
    public partial class First_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itm_Catogory",
                columns: table => new
                {
                    Catogry_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itm_Catogory", x => x.Catogry_Id);
                });

            migrationBuilder.CreateTable(
                name: "Itm_Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryCatogry_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itm_Product", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Itm_Product_Itm_Catogory_CategoryCatogry_Id",
                        column: x => x.CategoryCatogry_Id,
                        principalTable: "Itm_Catogory",
                        principalColumn: "Catogry_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itm_Product_CategoryCatogry_Id",
                table: "Itm_Product",
                column: "CategoryCatogry_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itm_Product");

            migrationBuilder.DropTable(
                name: "Itm_Catogory");
        }
    }
}
