using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Type1TPH
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Trainer { get; set; }
    }

    public class OnlineCourse : Course
    {
        public string URL { get; set; }
    }

    public class OfflineCourse : Course
    {
        public string Address { get; set; }
    }
    public class TPHContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public TPHContext() : base("name=TPH") 
        {
            Database.SetInitializer<TPHContext>(new DropCreateDatabaseIfModelChanges<TPHContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
            .Map<OnlineCourse>(m => m.Requires("Type").HasValue("OnlineCourse"))
            .Map<OfflineCourse>(m => m.Requires("Type").HasValue("OfflineCourse"));
        }
    }
}
