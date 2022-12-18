using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedRelationBetweenCourseAndFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseHomeId",
                table: "CourseFeatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatures_CourseHomeId",
                table: "CourseFeatures",
                column: "CourseHomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFeatures_CourseHomes_CourseHomeId",
                table: "CourseFeatures",
                column: "CourseHomeId",
                principalTable: "CourseHomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseFeatures_CourseHomes_CourseHomeId",
                table: "CourseFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CourseFeatures_CourseHomeId",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "CourseHomeId",
                table: "CourseFeatures");
        }
    }
}
