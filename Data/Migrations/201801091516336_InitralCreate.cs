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
                        AppKey = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        AppSecret = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        Title = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Remark = c.String(nullable: false, maxLength: 200, unicode: false, storeType: "nvarchar"),
                        Icon = c.String(nullable: false, maxLength: 1024, unicode: false, storeType: "nvarchar"),
                        ReturnUrl = c.String(nullable: false, maxLength: 1024, unicode: false, storeType: "nvarchar"),
                        IsEnable = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.AppKey);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        UserPwd = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        Nick = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        IsEnable = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.DiscountSets",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(unicode: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
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
                        Price = c.Decimal(nullable: false, precision: 18, scale: 3),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                        User = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ManageUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        UserPwd = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        Nick = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAdmin = c.Boolean(nullable: false),
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
                        Code = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        SizeA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SizeB = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Material = c.String(unicode: false),
                        MaterialId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 3),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealCodes",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        SizeA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SizeB = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CalSize = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.UserAuthOperates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SessionKey = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        Remark = c.String(nullable: false, maxLength: 1024, unicode: false, storeType: "nvarchar"),
                        IpAddress = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserAuthSessions",
                c => new
                    {
                        SessionKey = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        AppKey = c.String(nullable: false, maxLength: 32, unicode: false, storeType: "nvarchar"),
                        UserName = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        IpAddress = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                        InvalidTime = c.DateTime(nullable: false, precision: 0),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.SessionKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAuthSessions");
            DropTable("dbo.UserAuthOperates");
            DropTable("dbo.SealCodes");
            DropTable("dbo.Products");
            DropTable("dbo.Materials");
            DropTable("dbo.ManageUsers");
            DropTable("dbo.InquiryLogs");
            DropTable("dbo.DiscountSets");
            DropTable("dbo.AppUsers");
            DropTable("dbo.AppInfoes");
        }
    }
}
