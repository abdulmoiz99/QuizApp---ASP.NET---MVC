namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuizQuestionTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuizMasterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuizMaster", t => t.QuizMasterId, cascadeDelete: true)
                .Index(t => t.QuizMasterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizQuestions", "QuizMasterId", "dbo.QuizMaster");
            DropIndex("dbo.QuizQuestions", new[] { "QuizMasterId" });
            DropTable("dbo.QuizQuestions");
        }
    }
}
