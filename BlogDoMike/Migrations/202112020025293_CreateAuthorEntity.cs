namespace BlogDoMike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAuthorEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "Author_Id", c => c.Int());
            CreateIndex("dbo.Posts", "Author_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropColumn("dbo.Posts", "Author_Id");
            DropTable("dbo.Authors");
        }
    }
}
