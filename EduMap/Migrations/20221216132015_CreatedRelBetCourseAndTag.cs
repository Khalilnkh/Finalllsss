using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedRelBetCourseAndTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseHomeId",
                table: "CourseTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "CourseTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseTags_CourseHomeId",
                table: "CourseTags",
                column: "CourseHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTags_TagsId",
                table: "CourseTags",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTags_CourseHomes_CourseHomeId",
                table: "CourseTags",
                column: "CourseHomeId",
                principalTable: "CourseHomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTags_Tags_TagsId",
                table: "CourseTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTags_CourseHomes_CourseHomeId",
                table: "CourseTags");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTags_Tags_TagsId",
                table: "CourseTags");

            migrationBuilder.DropIndex(
                name: "IX_CourseTags_CourseHomeId",
                table: "CourseTags");

            migrationBuilder.DropIndex(
                name: "IX_CourseTags_TagsId",
                table: "CourseTags");

            migrationBuilder.DropColumn(
                name: "CourseHomeId",
                table: "CourseTags");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "CourseTags");
        }
    }
}
