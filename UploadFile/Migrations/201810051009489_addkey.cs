namespace UploadFile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DownloadFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        File = c.String(),
                        Size = c.Long(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DownloadFiles");
        }
    }
}
