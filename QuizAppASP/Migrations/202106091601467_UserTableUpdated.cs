namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.QuizAnswers", "Answer", c => c.String(nullable: false));
            DropColumn("dbo.QuizAnswers", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuizAnswers", "Description", c => c.String(nullable: false));
            DropColumn("dbo.QuizAnswers", "Answer");
            DropColumn("dbo.Users", "Active");
        }
    }
}
