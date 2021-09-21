namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Chief_id", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Chief_id", c => c.Int(nullable: false));
        }
    }
}
