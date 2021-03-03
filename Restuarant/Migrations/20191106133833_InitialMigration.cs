using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    DishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DishName = table.Column<string>(nullable: true),
                    RestaurantName = table.Column<string>(nullable: true),
                    RestaurantAddress = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.DishId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AverageRating = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Waiter",
                columns: table => new
                {
                    WaiterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WaiterName = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiter", x => x.WaiterId);
                    table.ForeignKey(
                        name: "FK_Waiter_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantDish",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantDish", x => new { x.DishId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantDish_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantDish_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RestaurantName = table.Column<string>(nullable: true),
                    RestaurantAddress = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    DateOfVisit = table.Column<DateTime>(nullable: false),
                    DishName = table.Column<string>(nullable: true),
                    Stars = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false),
                    GuestId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    TableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WaiterName = table.Column<string>(nullable: true),
                    RestaurantName = table.Column<string>(nullable: true),
                    RestaurantAddress = table.Column<string>(nullable: true),
                    WaiterId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_Table_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Table_Waiter_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "Waiter",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewDish",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewDish", x => new { x.DishId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewDish_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewDish_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfVisit = table.Column<DateTime>(nullable: false),
                    GuestName = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guest_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guest_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestDish",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestDish", x => new { x.DishId, x.GuestId });
                    table.ForeignKey(
                        name: "FK_GuestDish_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestDish_Guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guest",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewGuest",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewGuest", x => new { x.GuestId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewGuest_Guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guest",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewGuest_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_PersonId",
                table: "Guest",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_TableId",
                table: "Guest",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestDish_GuestId",
                table: "GuestDish",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDish_RestaurantId",
                table: "RestaurantDish",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_RestaurantId",
                table: "Review",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDish_ReviewId",
                table: "ReviewDish",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewGuest_ReviewId",
                table: "ReviewGuest",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Table_RestaurantId",
                table: "Table",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Table_WaiterId",
                table: "Table",
                column: "WaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_PersonId",
                table: "Waiter",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestDish");

            migrationBuilder.DropTable(
                name: "RestaurantDish");

            migrationBuilder.DropTable(
                name: "ReviewDish");

            migrationBuilder.DropTable(
                name: "ReviewGuest");

            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Waiter");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
