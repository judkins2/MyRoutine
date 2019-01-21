namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Routine2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Routines", "RoutineName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Routines", "RoutineName", c => c.String());
        }
    }
}
