namespace LC.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileExtension : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "Extension", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "Extension");
        }
    }
}
