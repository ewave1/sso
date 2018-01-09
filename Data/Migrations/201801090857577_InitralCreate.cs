namespace SmartSSO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitralCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppInfoes",
                c => new
                    {
                        AppKey = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        AppSecret = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        Title = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Remark = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Icon = c.String(nullable: false, maxLength: 1024, storeType: "nvarchar"),
                        ReturnUrl = c.String(nullable: false, maxLength: 1024, storeType: "nvarchar"),
                        IsEnable = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.AppKey);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        UserPwd = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        Nick = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        IsEnable = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Factories",
                c => new
                    {
                        FactoryName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.FactoryName);
            
            CreateTable(
                "dbo.InquiryLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(unicode: false),
                        SizeA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SizeB = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Factory = c.String(unicode: false),
                        Number = c.Int(nullable: false),
                        Material = c.String(unicode: false),
                        MaterialId = c.Int(nullable: false),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                        User = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ManageUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        UserPwd = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        Nick = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        IsEnable = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Remark = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SizeA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SizeB = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Material = c.String(unicode: false),
                        MaterialId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAuthOperates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SessionKey = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        Remark = c.String(nullable: false, maxLength: 1024, storeType: "nvarchar"),
                        IpAddress = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserAuthSessions",
                c => new
                    {
                        SessionKey = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        AppKey = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        UserName = c.String(maxLength: 50, storeType: "nvarchar"),
                        IpAddress = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        InvalidTime = c.DateTime(nullable: false, precision: 0),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.SessionKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAuthSessions");
            DropTable("dbo.UserAuthOperates");
            DropTable("dbo.Products");
            DropTable("dbo.Materials");
            DropTable("dbo.ManageUsers");
            DropTable("dbo.InquiryLogs");
            DropTable("dbo.Factories");
            DropTable("dbo.AppUsers");
            DropTable("dbo.AppInfoes");
        }
    }
}
