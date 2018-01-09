namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealCodes", "CalSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "CalSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CalSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SealCodes", "CalSize");
        }
    }
}
