namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cars", newName: "Car");
            RenameTable(name: "dbo.Details", newName: "Detail");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Detail", newName: "Details");
            RenameTable(name: "dbo.Car", newName: "Cars");
        }
    }
}
