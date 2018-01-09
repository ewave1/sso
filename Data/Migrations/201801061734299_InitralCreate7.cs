namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InquiryLogs", "User", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InquiryLogs", "User", c => c.Int(nullable: false));
        }
    }
}
