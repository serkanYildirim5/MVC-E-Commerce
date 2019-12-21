namespace Mvc_E_Commerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Phone", c => c.String());
            AlterColumn("dbo.Users", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Address", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 250, unicode: false));
        }
    }
}
