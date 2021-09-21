namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Chief_id = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        Salary = c.Int(nullable: false),
                        DepartamentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.DepartamentId)
                .Index(t => t.DepartamentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartamentId", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "DepartamentId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departaments");
        }
    }
}
