namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDateToDateOnly : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoutineItems", "CompleteDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoutineItems", "CompleteDate", c => c.DateTime(nullable: false));
        }
    }
}
