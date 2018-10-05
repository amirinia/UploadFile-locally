namespace UploadFile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class urlfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DownloadFiles", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DownloadFiles", "Url");
        }
    }
}
