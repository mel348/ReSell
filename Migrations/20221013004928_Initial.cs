using Microsoft.EntityFrameworkCore.Migrations;

namespace ReSell.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GarageSales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingTitle = table.Column<string>(maxLength: 5, nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Date = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarageSales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeItem = table.Column<string>(maxLength: 5, nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Zip = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GarageSalesID = table.Column<int>(nullable: false),
                    TradeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sellers_GarageSales_GarageSalesID",
                        column: x => x.GarageSalesID,
                        principalTable: "GarageSales",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sellers_Trades_TradeID",
                        column: x => x.TradeID,
                        principalTable: "Trades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GarageSales",
                columns: new[] { "ID", "Address", "City", "Date", "Description", "PostingTitle", "State", "Time", "Zipcode" },
                values: new object[] { 1, "555 Bounty Blvd.", "Traverse City", 0, "We have womens, mens, and childrens clothes.  Used Furniture, pet crate, lawn equipment, dvds, kitchenware, lamps, wall decor, and more knick knacks.", null, null, -100, 49684 });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "ID", "City", "Email", "GarageSalesID", "Name", "State", "TradeID", "Zip" },
                values: new object[] { 1, null, null, 0, null, null, 0, null });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "ID", "City", "Description", "State", "TradeItem", "Zipcode" },
                values: new object[] { 1, "Traverse City", "I would like to trade my 2018 Kubota ZD1211 Lawn Mower, which I paid $18,900 for in 2018, only used at home, and is worth around $13,500 used.  I sold my home and no longer need this.I am in need of a pickup truck or suv for the winter season.", "MI", "Lawn Mower", 49686 });

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_GarageSalesID",
                table: "Sellers",
                column: "GarageSalesID");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_TradeID",
                table: "Sellers",
                column: "TradeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "GarageSales");

            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
