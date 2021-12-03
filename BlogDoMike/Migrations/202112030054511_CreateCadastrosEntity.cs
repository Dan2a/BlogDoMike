namespace BlogDoMike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCadastrosEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadastroUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        CPF = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 150),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(),
                        TelefoneId = c.Int(nullable: false),
                        Telefones_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Telefones", t => t.Telefones_Id)
                .Index(t => t.Telefones_Id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CadastroUsers", "Telefones_Id", "dbo.Telefones");
            DropIndex("dbo.CadastroUsers", new[] { "Telefones_Id" });
            DropTable("dbo.Telefones");
            DropTable("dbo.CadastroUsers");
        }
    }
}
