namespace HtmlHelperDataAnnotation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Students", "Department", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "Department", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
