namespace Type2_TPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hai : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OfflineCourse");
            DropPrimaryKey("dbo.OnlineCourse");
            AlterColumn("dbo.OfflineCourse", "CourseId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OnlineCourse", "CourseId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.OfflineCourse", "CourseId");
            AddPrimaryKey("dbo.OnlineCourse", "CourseId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.OnlineCourse");
            DropPrimaryKey("dbo.OfflineCourse");
            AlterColumn("dbo.OnlineCourse", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.OfflineCourse", "CourseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OnlineCourse", "CourseId");
            AddPrimaryKey("dbo.OfflineCourse", "CourseId");
        }
    }
}
