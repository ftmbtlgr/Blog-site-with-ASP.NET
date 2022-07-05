namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Blogs", newName: "Blog1");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Blog1", newName: "Blogs");
        }
    }
}
