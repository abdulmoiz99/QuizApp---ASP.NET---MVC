namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOptionColumnToAnswerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuizAnswers", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuizAnswers", "Description");
        }
    }
}
