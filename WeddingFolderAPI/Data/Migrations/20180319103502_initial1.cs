using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WeddingFolderAPI.Data.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    BudgetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaxCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.BudgetId);
                });

            migrationBuilder.CreateTable(
                name: "Couple",
                columns: table => new
                {
                    CoupleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoupleName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couple", x => x.CoupleId);
                });

            migrationBuilder.CreateTable(
                name: "GuestList",
                columns: table => new
                {
                    GuestListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoupleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestList", x => x.GuestListId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    DateBooked = table.Column<DateTime>(nullable: false),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "ToDoList",
                columns: table => new
                {
                    ToDoListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoList", x => x.ToDoListId);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    WishlistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.WishlistId);
                });

            migrationBuilder.CreateTable(
                name: "BudgetItem",
                columns: table => new
                {
                    BudgetItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BudgetId = table.Column<int>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetItem", x => x.BudgetItemId);
                    table.ForeignKey(
                        name: "FK_BudgetItem_Budget_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budget",
                        principalColumn: "BudgetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GuestListId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TableNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guest_GuestList_GuestListId",
                        column: x => x.GuestListId,
                        principalTable: "GuestList",
                        principalColumn: "GuestListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatingPlan",
                columns: table => new
                {
                    SeatingPlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoupleId = table.Column<int>(nullable: false),
                    GuestListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatingPlan", x => x.SeatingPlanId);
                    table.ForeignKey(
                        name: "FK_SeatingPlan_GuestList_GuestListId",
                        column: x => x.GuestListId,
                        principalTable: "GuestList",
                        principalColumn: "GuestListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wish",
                columns: table => new
                {
                    WishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MustHaveFactor = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    WishTitle = table.Column<string>(nullable: true),
                    WishlistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wish", x => x.WishId);
                    table.ForeignKey(
                        name: "FK_Wish_Wishlist_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlist",
                        principalColumn: "WishlistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToDoItem",
                columns: table => new
                {
                    ToDoItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Priority = table.Column<int>(nullable: false),
                    ResponsibleGuestId = table.Column<int>(nullable: true),
                    Task = table.Column<string>(nullable: true),
                    ToDoListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItem", x => x.ToDoItemId);
                    table.ForeignKey(
                        name: "FK_ToDoItem_Guest_ResponsibleGuestId",
                        column: x => x.ResponsibleGuestId,
                        principalTable: "Guest",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToDoItem_ToDoList_ToDoListId",
                        column: x => x.ToDoListId,
                        principalTable: "ToDoList",
                        principalColumn: "ToDoListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanningFolder",
                columns: table => new
                {
                    PlanningFolderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BudgetId = table.Column<int>(nullable: true),
                    CoupleId = table.Column<int>(nullable: true),
                    FolderName = table.Column<string>(nullable: true),
                    GuestListId = table.Column<int>(nullable: true),
                    LocationId = table.Column<int>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    SeatingPlanId = table.Column<int>(nullable: true),
                    ToDoListId = table.Column<int>(nullable: true),
                    WishlistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningFolder", x => x.PlanningFolderId);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_Budget_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budget",
                        principalColumn: "BudgetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_Couple_CoupleId",
                        column: x => x.CoupleId,
                        principalTable: "Couple",
                        principalColumn: "CoupleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_GuestList_GuestListId",
                        column: x => x.GuestListId,
                        principalTable: "GuestList",
                        principalColumn: "GuestListId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_SeatingPlan_SeatingPlanId",
                        column: x => x.SeatingPlanId,
                        principalTable: "SeatingPlan",
                        principalColumn: "SeatingPlanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_ToDoList_ToDoListId",
                        column: x => x.ToDoListId,
                        principalTable: "ToDoList",
                        principalColumn: "ToDoListId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanningFolder_Wishlist_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlist",
                        principalColumn: "WishlistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlanningFolderId = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendor_PlanningFolder_PlanningFolderId",
                        column: x => x.PlanningFolderId,
                        principalTable: "PlanningFolder",
                        principalColumn: "PlanningFolderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetItem_BudgetId",
                table: "BudgetItem",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_GuestListId",
                table: "Guest",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_BudgetId",
                table: "PlanningFolder",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_CoupleId",
                table: "PlanningFolder",
                column: "CoupleId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_GuestListId",
                table: "PlanningFolder",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_LocationId",
                table: "PlanningFolder",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_SeatingPlanId",
                table: "PlanningFolder",
                column: "SeatingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_ToDoListId",
                table: "PlanningFolder",
                column: "ToDoListId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_WishlistId",
                table: "PlanningFolder",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatingPlan_GuestListId",
                table: "SeatingPlan",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItem_ResponsibleGuestId",
                table: "ToDoItem",
                column: "ResponsibleGuestId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItem_ToDoListId",
                table: "ToDoItem",
                column: "ToDoListId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PlanningFolderId",
                table: "Vendor",
                column: "PlanningFolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Wish_WishlistId",
                table: "Wish",
                column: "WishlistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetItem");

            migrationBuilder.DropTable(
                name: "ToDoItem");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Wish");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "PlanningFolder");

            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropTable(
                name: "Couple");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "SeatingPlan");

            migrationBuilder.DropTable(
                name: "ToDoList");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "GuestList");
        }
    }
}
