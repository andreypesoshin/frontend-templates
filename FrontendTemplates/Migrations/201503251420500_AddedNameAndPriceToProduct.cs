namespace FrontendTemplates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameAndPriceToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
            AddColumn("dbo.Products", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Name");
        }
    }
}
