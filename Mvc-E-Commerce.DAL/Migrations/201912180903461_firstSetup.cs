namespace Mvc_E_Commerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertising",
                c => new
                    {
                        AdvertisingId = c.Int(nullable: false, identity: true),
                        Path = c.String(maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdvertisingId);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        BasketId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BasketId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 250, unicode: false),
                        CategoryId = c.Int(nullable: false),
                        Brand = c.String(maxLength: 250, unicode: false),
                        Model = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 500, unicode: false),
                        Price = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Picture = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 250, unicode: false),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 250, unicode: false),
                        LastName = c.String(maxLength: 250, unicode: false),
                        UserName = c.String(maxLength: 250, unicode: false),
                        Password = c.String(maxLength: 250, unicode: false),
                        Email = c.String(maxLength: 250, unicode: false),
                        Phone = c.String(maxLength: 250, unicode: false),
                        Address = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentTitle = c.String(maxLength: 50, unicode: false),
                        CommentContent = c.String(maxLength: 350, unicode: false),
                        CreateDate = c.DateTime(nullable: false, storeType: "date"),
                        ProductId = c.Int(nullable: false),
                        FullName = c.String(maxLength: 150, unicode: false),
                        Mail = c.String(maxLength: 150, unicode: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.ProductId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.WishList",
                c => new
                    {
                        WishListID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.WishListID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Product_ProductId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Order_Products_Table",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.PostId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.PostId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.WishList_Product_Table",
                c => new
                    {
                        WishListId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WishListId, t.ProductId })
                .ForeignKey("dbo.WishList", t => t.WishListId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.WishListId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Baskets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Baskets", "ProductId", "dbo.Products");
            DropForeignKey("dbo.WishList", "UserID", "dbo.Users");
            DropForeignKey("dbo.WishList_Product_Table", "ProductId", "dbo.Products");
            DropForeignKey("dbo.WishList_Product_Table", "WishListId", "dbo.WishList");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Order_Products_Table", "PostId", "dbo.Products");
            DropForeignKey("dbo.Order_Products_Table", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropForeignKey("dbo.CategoryProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.CategoryProducts", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Baskets", new[] { "UserId" });
            DropIndex("dbo.Baskets", new[] { "ProductId" });
            DropIndex("dbo.WishList", new[] { "UserID" });
            DropIndex("dbo.WishList_Product_Table", new[] { "ProductId" });
            DropIndex("dbo.WishList_Product_Table", new[] { "WishListId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "User_UserId" });
            DropIndex("dbo.Comments", new[] { "ProductId" });
            DropIndex("dbo.Order_Products_Table", new[] { "PostId" });
            DropIndex("dbo.Order_Products_Table", new[] { "OrderId" });
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropIndex("dbo.CategoryProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.CategoryProducts", new[] { "Category_CategoryId" });
            DropTable("dbo.WishList_Product_Table");
            DropTable("dbo.Order_Products_Table");
            DropTable("dbo.CategoryProducts");
            DropTable("dbo.WishList");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Baskets");
            DropTable("dbo.Advertising");
        }
    }
}
