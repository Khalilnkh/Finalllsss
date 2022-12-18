using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduMap.Migrations
{
    public partial class CreatedTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
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
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    FullName = table.Column<string>(maxLength: 1000, nullable: true),
                    Profession = table.Column<string>(maxLength: 1000, nullable: true),
                    FacebookLink = table.Column<string>(maxLength: 1000, nullable: true),
                    PinterestLink = table.Column<string>(maxLength: 1000, nullable: true),
                    TwitterLink = table.Column<string>(maxLength: 1000, nullable: true),
                    VimeoLink = table.Column<string>(maxLength: 1000, nullable: true),
                    AboutMe = table.Column<string>(maxLength: 1000, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    Degree = table.Column<string>(maxLength: 2000, nullable: true),
                    Experience = table.Column<string>(maxLength: 1000, nullable: true),
                    Hobbies = table.Column<string>(maxLength: 1000, nullable: true),
                    Facculty = table.Column<string>(maxLength: 1000, nullable: true),
                    Mail = table.Column<string>(maxLength: 1000, nullable: true),
                    Call = table.Column<string>(maxLength: 1000, nullable: true),
                    Skype = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
