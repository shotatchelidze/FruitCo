namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeContainerToIngredient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Containers", "Information_Id", "dbo.Information");
            DropIndex("dbo.Containers", new[] { "Information_Id" });
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IngredientTitle = c.String(maxLength: 50),
                        Information_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Information", t => t.Information_Id)
                .Index(t => t.Information_Id);
            
            DropTable("dbo.Containers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Containers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        PhotoPath = c.String(maxLength: 50),
                        Information_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Ingredients", "Information_Id", "dbo.Information");
            DropIndex("dbo.Ingredients", new[] { "Information_Id" });
            DropTable("dbo.Ingredients");
            CreateIndex("dbo.Containers", "Information_Id");
            AddForeignKey("dbo.Containers", "Information_Id", "dbo.Information", "Id");
        }
    }
}
