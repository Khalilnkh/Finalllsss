using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedCourseDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseDetails",
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
                    CourseImage = table.Column<string>(maxLength: 1000, nullable: true),
                    CourseName = table.Column<string>(maxLength: 1000, nullable: true),
                    CourseDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    AboutCourse = table.Column<string>(maxLength: 1000, nullable: true),
                    AboutDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    Apply = table.Column<string>(maxLength: 1000, nullable: true),
                    ApplyDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    Certification = table.Column<string>(maxLength: 1000, nullable: true),
                    CertificationDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDetails");
        }
    }
}
