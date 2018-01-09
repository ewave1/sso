namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealCodes", "SizeA", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.SealCodes", "SizeB", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealCodes", "SizeB", c => c.String());
            AlterColumn("dbo.SealCodes", "SizeA", c => c.String());
        }
    }
}
