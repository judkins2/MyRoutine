namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompleteDateToRoutineItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoutineItems", "CompleteDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoutineItems", "CompleteDate");
        }
    }
}
