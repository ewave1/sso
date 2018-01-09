namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
     
    public partial class InitralCreate14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ManageUsers", "IsAdmin", c => c.Boolean(nullable: false));
            DropColumn("dbo.ManageUsers", "IsEnable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ManageUsers", "IsEnable", c => c.Boolean(nullable: false));
            DropColumn("dbo.ManageUsers", "IsAdmin");
        }
    }
}
