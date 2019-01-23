namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDate_CompleteToRoutine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Routines", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routines", "Complete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Routines", "Complete");
            DropColumn("dbo.Routines", "CreateDate");
        }
    }
}
