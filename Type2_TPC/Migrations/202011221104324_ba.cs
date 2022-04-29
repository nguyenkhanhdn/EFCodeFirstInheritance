namespace Type2_TPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ba : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OfflineCourse");
            DropPrimaryKey("dbo.OnlineCourse");
            AddColumn("dbo.OfflineCourse", "Id", c => c.Int(nullable: false));
            AddColumn("dbo.OnlineCourse", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OfflineCourse", "Id");
            AddPrimaryKey("dbo.OnlineCourse", "Id");
            DropColumn("dbo.OfflineCourse", "CourseId");
            DropColumn("dbo.OnlineCourse", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OnlineCourse", "CourseId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.OfflineCourse", "CourseId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.OnlineCourse");
            DropPrimaryKey("dbo.OfflineCourse");
            DropColumn("dbo.OnlineCourse", "Id");
            DropColumn("dbo.OfflineCourse", "Id");
            AddPrimaryKey("dbo.OnlineCourse", "CourseId");
            AddPrimaryKey("dbo.OfflineCourse", "CourseId");
        }
    }
}
