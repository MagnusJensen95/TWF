using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WeddingFolderAPI.Data.Migrations
{
    public partial class allrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetItem_Budget_BudgetId",
                table: "BudgetItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_Budget_BudgetId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_Couple_CoupleId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_GuestList_GuestListId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_Location_LocationId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_SeatingPlan_SeatingPlanId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_ToDoList_ToDoListId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_Wishlist_WishlistId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_PlanningFolder_PlanningFolderId",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_BudgetId",
                table: "PlanningFolder");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_GuestListId",
                table: "PlanningFolder");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_LocationId",
                table: "PlanningFolder");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_SeatingPlanId",
                table: "PlanningFolder");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_ToDoListId",
                table: "PlanningFolder");

            migrationBuilder.DropIndex(
                name: "IX_PlanningFolder_WishlistId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "GuestListId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "SeatingPlanId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "ToDoListId",
                table: "PlanningFolder");

            migrationBuilder.DropColumn(
                name: "WishlistId",
                table: "PlanningFolder");

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "Wishlist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlanningFolderId",
                table: "Vendor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "ToDoList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "SeatingPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CoupleId",
                table: "PlanningFolder",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "GuestList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BudgetId",
                table: "BudgetItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanningFolderId",
                table: "Budget",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_PlanningFolderId",
                table: "Wishlist",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoList_PlanningFolderId",
                table: "ToDoList",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatingPlan_PlanningFolderId",
                table: "SeatingPlan",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_PlanningFolderId",
                table: "Location",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuestList_PlanningFolderId",
                table: "GuestList",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Budget_PlanningFolderId",
                table: "Budget",
                column: "PlanningFolderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_PlanningFolder_PlanningFolderId",
                table: "Budget",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetItem_Budget_BudgetId",
                table: "BudgetItem",
                column: "BudgetId",
                principalTable: "Budget",
                principalColumn: "BudgetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestList_PlanningFolder_PlanningFolderId",
                table: "GuestList",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_PlanningFolder_PlanningFolderId",
                table: "Location",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_Couple_CoupleId",
                table: "PlanningFolder",
                column: "CoupleId",
                principalTable: "Couple",
                principalColumn: "CoupleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatingPlan_PlanningFolder_PlanningFolderId",
                table: "SeatingPlan",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoList_PlanningFolder_PlanningFolderId",
                table: "ToDoList",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_PlanningFolder_PlanningFolderId",
                table: "Vendor",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_PlanningFolder_PlanningFolderId",
                table: "Wishlist",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_PlanningFolder_PlanningFolderId",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_BudgetItem_Budget_BudgetId",
                table: "BudgetItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestList_PlanningFolder_PlanningFolderId",
                table: "GuestList");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_PlanningFolder_PlanningFolderId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanningFolder_Couple_CoupleId",
                table: "PlanningFolder");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatingPlan_PlanningFolder_PlanningFolderId",
                table: "SeatingPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoList_PlanningFolder_PlanningFolderId",
                table: "ToDoList");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_PlanningFolder_PlanningFolderId",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_PlanningFolder_PlanningFolderId",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_PlanningFolderId",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_ToDoList_PlanningFolderId",
                table: "ToDoList");

            migrationBuilder.DropIndex(
                name: "IX_SeatingPlan_PlanningFolderId",
                table: "SeatingPlan");

            migrationBuilder.DropIndex(
                name: "IX_Location_PlanningFolderId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_GuestList_PlanningFolderId",
                table: "GuestList");

            migrationBuilder.DropIndex(
                name: "IX_Budget_PlanningFolderId",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "Wishlist");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "ToDoList");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "SeatingPlan");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "GuestList");

            migrationBuilder.DropColumn(
                name: "PlanningFolderId",
                table: "Budget");

            migrationBuilder.AlterColumn<int>(
                name: "PlanningFolderId",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CoupleId",
                table: "PlanningFolder",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BudgetId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuestListId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatingPlanId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToDoListId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WishlistId",
                table: "PlanningFolder",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BudgetId",
                table: "BudgetItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PlanningFolder_BudgetId",
                table: "PlanningFolder",
                column: "BudgetId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetItem_Budget_BudgetId",
                table: "BudgetItem",
                column: "BudgetId",
                principalTable: "Budget",
                principalColumn: "BudgetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_Budget_BudgetId",
                table: "PlanningFolder",
                column: "BudgetId",
                principalTable: "Budget",
                principalColumn: "BudgetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_Couple_CoupleId",
                table: "PlanningFolder",
                column: "CoupleId",
                principalTable: "Couple",
                principalColumn: "CoupleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_GuestList_GuestListId",
                table: "PlanningFolder",
                column: "GuestListId",
                principalTable: "GuestList",
                principalColumn: "GuestListId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_Location_LocationId",
                table: "PlanningFolder",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_SeatingPlan_SeatingPlanId",
                table: "PlanningFolder",
                column: "SeatingPlanId",
                principalTable: "SeatingPlan",
                principalColumn: "SeatingPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_ToDoList_ToDoListId",
                table: "PlanningFolder",
                column: "ToDoListId",
                principalTable: "ToDoList",
                principalColumn: "ToDoListId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanningFolder_Wishlist_WishlistId",
                table: "PlanningFolder",
                column: "WishlistId",
                principalTable: "Wishlist",
                principalColumn: "WishlistId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_PlanningFolder_PlanningFolderId",
                table: "Vendor",
                column: "PlanningFolderId",
                principalTable: "PlanningFolder",
                principalColumn: "PlanningFolderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
