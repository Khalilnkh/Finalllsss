using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedCourseFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseFeatures",
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
                    Time = table.Column<int>(maxLength: 1000, nullable: false),
                    Duration = table.Column<string>(maxLength: 1000, nullable: true),
                    ClassDuration = table.Column<string>(maxLength: 1000, nullable: true),
                    SkillLevel = table.Column<string>(maxLength: 1000, nullable: true),
                    Language = table.Column<string>(maxLength: 1000, nullable: true),
                    StudentCount = table.Column<int>(maxLength: 1000, nullable: false),
                    Assign = table.Column<int>(maxLength: 1000, nullable: false),
                    CourseFee = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseFeatures");
        }
    }
}
