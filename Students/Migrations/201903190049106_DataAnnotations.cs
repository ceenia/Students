namespace Students.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Status", c => c.String(maxLength: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Status", c => c.String());
            AlterColumn("dbo.Students", "Gender", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
