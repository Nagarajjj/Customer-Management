using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTable",
                columns: table => new
                {
                    CustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(nullable: true),
                    CustAddress = table.Column<string>(nullable: true),
                    CustBarrowedBooks = table.Column<int>(nullable: false),
                    CustPhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTable", x => x.CustId);
                });

            migrationBuilder.InsertData(
                table: "CustomerTable",
                columns: new[] { "CustId", "CustAddress", "CustBarrowedBooks", "CustName", "CustPhoto" },
                values: new object[] { 1, "Benagaluru", 2, "Nagaraj", "https://i.kinja-img.com/gawker-media/image/upload/t_original/ijsi5fzb1nbkbhxa2gc1.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTable");
        }
    }
}
