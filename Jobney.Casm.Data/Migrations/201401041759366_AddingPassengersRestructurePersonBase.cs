namespace Jobney.Casm.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPassengersRestructurePersonBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Passenger");
        }
    }
}
