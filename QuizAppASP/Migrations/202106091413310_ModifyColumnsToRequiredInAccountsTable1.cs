namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyColumnsToRequiredInAccountsTable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
        }
    }
}
