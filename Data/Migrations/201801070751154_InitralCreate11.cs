namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InquiryLogs", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.InquiryLogs", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
