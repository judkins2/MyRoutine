namespace MyRoutine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutineItem1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoutineItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Complete = c.Byte(nullable: false),
                        RoutineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routines", t => t.RoutineID, cascadeDelete: true)
                .Index(t => t.RoutineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoutineItems", "RoutineID", "dbo.Routines");
            DropIndex("dbo.RoutineItems", new[] { "RoutineID" });
            DropTable("dbo.RoutineItems");
        }
    }
}
