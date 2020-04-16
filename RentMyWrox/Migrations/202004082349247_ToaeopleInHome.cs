namespace RentMyWrox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToaeopleInHome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDemographics", "TotalPeopleInHome", c => c.Int(nullable: false));
            DropColumn("dbo.UserDemographics", "TotalNumberInHome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDemographics", "TotalNumberInHome", c => c.Int(nullable: false));
            DropColumn("dbo.UserDemographics", "TotalPeopleInHome");
        }
    }
}
