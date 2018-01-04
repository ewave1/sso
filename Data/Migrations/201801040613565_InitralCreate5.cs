namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InquiryLogs", "Factory", c => c.String());
            DropColumn("dbo.InquiryLogs", "Source");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InquiryLogs", "Source", c => c.Int(nullable: false));
            DropColumn("dbo.InquiryLogs", "Factory");
        }
    }
}
