namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuizMasterColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizMaster",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 256),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy, cascadeDelete: true)
                .Index(t => t.CreatedBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizMaster", "CreatedBy", "dbo.Users");
            DropIndex("dbo.QuizMaster", new[] { "CreatedBy" });
            DropTable("dbo.QuizMaster");
        }
    }
}
