namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CalSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CalSize");
        }
    }
}
