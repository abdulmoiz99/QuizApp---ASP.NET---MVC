namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveIdFromQuizScoresTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.QuizScores", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuizScores", "Id", c => c.Int(nullable: false));
        }
    }
}
