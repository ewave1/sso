namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiscountSets",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 50),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            DropTable("dbo.Factories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Factories",
                c => new
                    {
                        FactoryName = c.String(nullable: false, maxLength: 50),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FactoryName);
            
            DropTable("dbo.DiscountSets");
        }
    }
}
