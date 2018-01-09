namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factories", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Factories", "Type");
        }
    }
}
