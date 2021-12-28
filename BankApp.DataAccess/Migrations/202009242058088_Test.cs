namespace BankApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CsAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        AdditionalNumber = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        AccountState = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.CsAdresses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TcNo = c.String(),
                        CustomerNo = c.Int(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TcNo = c.Int(nullable: false),
                        Password = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CsAdresses", "Id", "dbo.Customers");
            DropForeignKey("dbo.Logins", "Id", "dbo.Customers");
            DropForeignKey("dbo.CsAccounts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Logins", new[] { "Id" });
            DropIndex("dbo.CsAdresses", new[] { "Id" });
            DropIndex("dbo.CsAccounts", new[] { "CustomerId" });
            DropTable("dbo.Logins");
            DropTable("dbo.Customers");
            DropTable("dbo.CsAdresses");
            DropTable("dbo.CsAccounts");
        }
    }
}
