namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionColumnToQuestionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuizQuestions", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuizQuestions", "Description");
        }
    }
}
