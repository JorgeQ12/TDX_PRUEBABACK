using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TdxBackend.Migrations
{
    /// <inheritdoc />
    public partial class TdxMigrationV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateTask",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTask", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaskTdx",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdStateTask = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTdx", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaskTdx_StateTask_IdStateTask",
                        column: x => x.IdStateTask,
                        principalTable: "StateTask",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskTdx_IdStateTask",
                table: "TaskTdx",
                column: "IdStateTask");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskTdx");

            migrationBuilder.DropTable(
                name: "StateTask");
        }
    }
}
