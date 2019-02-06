namespace Vidly_new.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubsribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubsribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubsribedToNewsletter");
        }
    }
}
