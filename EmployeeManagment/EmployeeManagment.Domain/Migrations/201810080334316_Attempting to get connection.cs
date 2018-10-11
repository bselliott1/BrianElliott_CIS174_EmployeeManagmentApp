namespace EmployeeManagment.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Attemptingtogetconnection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PayRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employees", "SalaryType", c => c.String());
            AlterColumn("dbo.Employees", "BirthDate", c => c.String());
            AlterColumn("dbo.Employees", "HireDate", c => c.String());
            DropColumn("dbo.Employees", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Employees", "SalaryType");
            DropColumn("dbo.Employees", "PayRate");
        }
    }
}
