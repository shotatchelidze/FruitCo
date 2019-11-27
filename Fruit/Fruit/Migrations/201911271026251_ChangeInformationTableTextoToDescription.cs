namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInformationTableTextoToDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Information", "Description", c => c.String(maxLength: 4000));
            DropColumn("dbo.Information", "Text");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Information", "Text", c => c.String(maxLength: 4000));
            DropColumn("dbo.Information", "Description");
        }
    }
}
