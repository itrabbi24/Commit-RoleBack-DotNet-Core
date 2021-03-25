using Microsoft.EntityFrameworkCore.Migrations;

namespace AjaxCrud.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "Nvarchar(12)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    BankName = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    SWIFTCode = table.Column<string>(type: "Nvarchar(11)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactions");
        }
    }
}
