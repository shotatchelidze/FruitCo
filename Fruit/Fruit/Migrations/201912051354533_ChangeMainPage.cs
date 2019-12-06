namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMainPage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "Information_Id", "dbo.Information");
            DropIndex("dbo.Ingredients", new[] { "Information_Id" });
            CreateTable(
                "dbo.MainPages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Subtitle = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Images", "PageName", c => c.String());
            AddColumn("dbo.Images", "ImagePath", c => c.String());
            AddColumn("dbo.Images", "SortIndex", c => c.Int(nullable: false));
            AddColumn("dbo.Images", "MainPage_Id", c => c.Int());
            CreateIndex("dbo.Images", "MainPage_Id");
            AddForeignKey("dbo.Images", "MainPage_Id", "dbo.MainPages", "Id");
            DropColumn("dbo.Ingredients", "Information_Id");
            DropColumn("dbo.Images", "Name");
            DropTable("dbo.Information");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Subtitle = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Images", "Name", c => c.String());
            AddColumn("dbo.Ingredients", "Information_Id", c => c.Int());
            DropForeignKey("dbo.Images", "MainPage_Id", "dbo.MainPages");
            DropIndex("dbo.Images", new[] { "MainPage_Id" });
            DropColumn("dbo.Images", "MainPage_Id");
            DropColumn("dbo.Images", "SortIndex");
            DropColumn("dbo.Images", "ImagePath");
            DropColumn("dbo.Images", "PageName");
            DropTable("dbo.MainPages");
            CreateIndex("dbo.Ingredients", "Information_Id");
            AddForeignKey("dbo.Ingredients", "Information_Id", "dbo.Information", "Id");
        }
    }
}
