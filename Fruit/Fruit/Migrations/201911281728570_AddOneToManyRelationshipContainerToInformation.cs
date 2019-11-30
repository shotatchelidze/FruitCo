namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOneToManyRelationshipContainerToInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Containers", "Information_Id", c => c.Int());
            CreateIndex("dbo.Containers", "Information_Id");
            AddForeignKey("dbo.Containers", "Information_Id", "dbo.Information", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Containers", "Information_Id", "dbo.Information");
            DropIndex("dbo.Containers", new[] { "Information_Id" });
            DropColumn("dbo.Containers", "Information_Id");
        }
    }
}
