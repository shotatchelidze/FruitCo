namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContainer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Containers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Containers");
        }
    }
}
