namespace Type2_TPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfflineCourse",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        Address = c.String(),
                        Name = c.String(),
                        Details = c.String(),
                        Trainer = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.OnlineCourse",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        URL = c.String(),
                        Name = c.String(),
                        Details = c.String(),
                        Trainer = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OnlineCourse");
            DropTable("dbo.OfflineCourse");
        }
    }
}
