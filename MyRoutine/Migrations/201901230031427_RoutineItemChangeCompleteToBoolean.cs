namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutineItemChangeCompleteToBoolean : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoutineItems", "Complete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoutineItems", "Complete", c => c.Byte(nullable: false));
        }
    }
}
