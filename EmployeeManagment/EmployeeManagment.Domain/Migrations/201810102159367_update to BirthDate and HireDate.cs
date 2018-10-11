namespace EmployeeManagment.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetoBirthDateandHireDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "HireDate", c => c.String());
            AlterColumn("dbo.Employees", "BirthDate", c => c.String());
        }
    }
}
