namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreDBChanges2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Routines", "CompleteDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Routines", "CompleteDate", c => c.DateTime(nullable: false));
        }
    }
}
