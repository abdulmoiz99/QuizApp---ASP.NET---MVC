namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuizAnswerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuizQuestionId = c.Int(nullable: false),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuizQuestions", t => t.QuizQuestionId, cascadeDelete: true)
                .Index(t => t.QuizQuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizAnswers", "QuizQuestionId", "dbo.QuizQuestions");
            DropIndex("dbo.QuizAnswers", new[] { "QuizQuestionId" });
            DropTable("dbo.QuizAnswers");
        }
    }
}
