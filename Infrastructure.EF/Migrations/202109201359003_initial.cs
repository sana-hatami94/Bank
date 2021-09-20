namespace Infrastructure.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BankAccounts", "PersonId", "dbo.People");
            DropIndex("dbo.BankAccounts", new[] { "PersonId" });
            DropColumn("dbo.BankAccounts", "PersonId");
            DropTable("dbo.People");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        MobileNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BankAccounts", "PersonId", c => c.Int(nullable: false));
            CreateIndex("dbo.BankAccounts", "PersonId");
            AddForeignKey("dbo.BankAccounts", "PersonId", "dbo.People", "Id", cascadeDelete: true);
        }
    }
}
