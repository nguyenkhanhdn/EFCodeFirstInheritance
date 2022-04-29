using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type3
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Trainer { get; set; }
    }
    [Table("OnlineCourse")]
    public class OnlineCourse : Course
    {
        public string URL { get; set; }
    }
    [Table("OfflineCourse")]
    public class OfflineCourse : Course
    {
        public string Address { get; set; }
    }
    public class TPTContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public TPTContext() : base("name=TPT") 
        {
            Database.SetInitializer<TPTContext>(new DropCreateDatabaseIfModelChanges<TPTContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<OnlineCourse>().ToTable("OnlineCourse");
            modelBuilder.Entity<OfflineCourse>().ToTable("OfflineCourse");
        }
    }
}
