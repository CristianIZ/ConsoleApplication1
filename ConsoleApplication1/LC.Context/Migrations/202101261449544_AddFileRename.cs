namespace LC.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileRename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "Rename", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "Rename");
        }
    }
}
