namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factories",
                c => new
                    {
                        FactoryName = c.String(nullable: false, maxLength: 50),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.FactoryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Factories");
        }
    }
}
