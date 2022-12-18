using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedProTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_noticeBoards",
                table: "noticeBoards");

            migrationBuilder.RenameTable(
                name: "noticeBoards",
                newName: "NoticeBoards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeBoards",
                table: "NoticeBoards",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    MainTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProTeachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoticeBoards",
                table: "NoticeBoards");

            migrationBuilder.RenameTable(
                name: "NoticeBoards",
                newName: "noticeBoards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_noticeBoards",
                table: "noticeBoards",
                column: "Id");
        }
    }
}
