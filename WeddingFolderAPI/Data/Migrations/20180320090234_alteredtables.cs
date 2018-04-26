using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WeddingFolderAPI.Data.Migrations
{
    public partial class alteredtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatingPlan_GuestList_GuestListId",
                table: "SeatingPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItem_Guest_ResponsibleGuestId",
                table: "ToDoItem");

            migrationBuilder.DropIndex(
                name: "IX_ToDoItem_ResponsibleGuestId",
                table: "ToDoItem");

            migrationBuilder.DropIndex(
                name: "IX_SeatingPlan_GuestListId",
                table: "SeatingPlan");

            migrationBuilder.DropColumn(
                name: "ResponsibleGuestId",
                table: "ToDoItem");

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "ToDoItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "GuestListId",
                table: "SeatingPlan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "ToDoItem");

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleGuestId",
                table: "ToDoItem",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuestListId",
                table: "SeatingPlan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItem_ResponsibleGuestId",
                table: "ToDoItem",
                column: "ResponsibleGuestId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatingPlan_GuestListId",
                table: "SeatingPlan",
                column: "GuestListId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeatingPlan_GuestList_GuestListId",
                table: "SeatingPlan",
                column: "GuestListId",
                principalTable: "GuestList",
                principalColumn: "GuestListId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItem_Guest_ResponsibleGuestId",
                table: "ToDoItem",
                column: "ResponsibleGuestId",
                principalTable: "Guest",
                principalColumn: "GuestId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
