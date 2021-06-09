namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuizScoreTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuizMaster", "CreatedBy", "dbo.Users");
            CreateTable(
                "dbo.QuizScores",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        QuizId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        DateAttempted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.QuizId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.QuizMaster", t => t.QuizId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.QuizId);
            
            AddForeignKey("dbo.QuizMaster", "CreatedBy", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizMaster", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.QuizScores", "QuizId", "dbo.QuizMaster");
            DropForeignKey("dbo.QuizScores", "UserId", "dbo.Users");
            DropIndex("dbo.QuizScores", new[] { "QuizId" });
            DropIndex("dbo.QuizScores", new[] { "UserId" });
            DropTable("dbo.QuizScores");
            AddForeignKey("dbo.QuizMaster", "CreatedBy", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
