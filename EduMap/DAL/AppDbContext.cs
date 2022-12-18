using EduMap.Models;
using Microsoft.EntityFrameworkCore;

namespace EduMap.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<ProTeacher> ProTeachers { get; set; }
        public DbSet<WhyChoose> WhyChooses { get; set; }
        public DbSet<FooterSlider> FooterSliders { get; set; }
        public DbSet<CourseHome> CourseHomes { get; set; }
        public DbSet<EventsHome> EventsHomes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutStart> AboutStarts { get; set; }
        public DbSet<AboutTeacher> AboutTeachers { get; set; }
        public DbSet<CoursePage> CoursePages { get; set; }
        public DbSet<CourseDetail>CourseDetails{ get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherHobbies> TeacherHobbies { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        















    }
}
