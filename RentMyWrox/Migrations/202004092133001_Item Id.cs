namespace RentMyWrox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                        Cost = c.Double(nullable: false),
                        Checkout = c.DateTime(),
                        DueBack = c.DateTime(),
                        DateAcquired = c.DateTime(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
