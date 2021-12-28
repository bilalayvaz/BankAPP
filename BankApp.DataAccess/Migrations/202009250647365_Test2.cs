namespace BankApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "TcNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "TcNo", c => c.Int(nullable: false));
        }
    }
}
