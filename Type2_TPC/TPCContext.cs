using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Type2_TPC
{
    public abstract class Course //abstract class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Trainer { get; set; }
    }
    public class OnlineCourse : Course //concrete class
    {
        public string URL { get; set; }
    }
    public class OfflineCourse : Course //concrete class
    {
        public string Address { get; set; }
    }
    public class TPCContext:DbContext
    {
        public DbSet<OfflineCourse> OfflineCourses { get; set; }
        public DbSet<OnlineCourse> OnlineCourses { get; set; }
        public TPCContext()
            : base("name=TPC")
        {
            Database.SetInitializer<TPCContext>(new DropCreateDatabaseIfModelChanges<TPCContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OnlineCourse>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("OnlineCourse ");
            });
            modelBuilder.Entity<OfflineCourse>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("OfflineCourse ");
            });

           
        }
    }
}
