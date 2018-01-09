namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SealCodes",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        SizeA = c.String(),
                        SizeB = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SealCodes");
        }
    }
}
