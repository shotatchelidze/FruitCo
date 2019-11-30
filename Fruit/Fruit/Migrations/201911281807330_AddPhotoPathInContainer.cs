namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoPathInContainer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Containers", "PhotoPath", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Containers", "PhotoPath");
        }
    }
}
