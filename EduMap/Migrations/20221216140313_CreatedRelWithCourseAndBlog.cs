using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedRelWithCourseAndBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseHomeId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CourseHomeId",
                table: "Blogs",
                column: "CourseHomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_CourseHomes_CourseHomeId",
                table: "Blogs",
                column: "CourseHomeId",
                principalTable: "CourseHomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_CourseHomes_CourseHomeId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CourseHomeId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CourseHomeId",
                table: "Blogs");
        }
    }
}
