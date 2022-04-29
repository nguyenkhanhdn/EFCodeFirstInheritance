namespace Type2_TPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bon : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OfflineCourse");
            DropPrimaryKey("dbo.OnlineCourse");
            AlterColumn("dbo.OfflineCourse", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OnlineCourse", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.OfflineCourse", "Id");
            AddPrimaryKey("dbo.OnlineCourse", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.OnlineCourse");
            DropPrimaryKey("dbo.OfflineCourse");
            AlterColumn("dbo.OnlineCourse", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OfflineCourse", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OnlineCourse", "Id");
            AddPrimaryKey("dbo.OfflineCourse", "Id");
        }
    }
}
