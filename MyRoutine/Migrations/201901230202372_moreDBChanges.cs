namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreDBChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Routines", "CompleteDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routines", "FinalizedDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Routines", "FinalizedDate");
            DropColumn("dbo.Routines", "CompleteDate");
        }
    }
}
