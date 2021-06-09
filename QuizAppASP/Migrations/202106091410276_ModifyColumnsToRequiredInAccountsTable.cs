namespace QuizAppASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyColumnsToRequiredInAccountsTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accounts", newName: "Users");
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            RenameTable(name: "dbo.Users", newName: "Accounts");
        }
    }
}
