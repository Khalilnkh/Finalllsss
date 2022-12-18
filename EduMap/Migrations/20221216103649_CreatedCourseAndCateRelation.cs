using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedCourseAndCateRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CourseHomes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseHomes_CategoryId",
                table: "CourseHomes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseHomes_Categories_CategoryId",
                table: "CourseHomes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseHomes_Categories_CategoryId",
                table: "CourseHomes");

            migrationBuilder.DropIndex(
                name: "IX_CourseHomes_CategoryId",
                table: "CourseHomes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CourseHomes");
        }
    }
}
