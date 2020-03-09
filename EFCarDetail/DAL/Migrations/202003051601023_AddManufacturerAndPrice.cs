namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManufacturerAndPrice : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Car", "Detail_Id", "dbo.Detail");
            DropIndex("dbo.Car", new[] { "Detail_Id" });
            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Car", "ManufacturerId", c => c.Int(nullable: false));
            AddColumn("dbo.Detail", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Detail", "ManufacturerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Car", "ManufacturerId");
            CreateIndex("dbo.Detail", "ManufacturerId");
            AddForeignKey("dbo.Car", "ManufacturerId", "dbo.Manufacturer", "Id");
            AddForeignKey("dbo.Detail", "ManufacturerId", "dbo.Manufacturer", "Id");
            DropColumn("dbo.Car", "Detail_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Car", "Detail_Id", c => c.Int());
            DropForeignKey("dbo.Detail", "ManufacturerId", "dbo.Manufacturer");
            DropForeignKey("dbo.Car", "ManufacturerId", "dbo.Manufacturer");
            DropIndex("dbo.Detail", new[] { "ManufacturerId" });
            DropIndex("dbo.Car", new[] { "ManufacturerId" });
            DropColumn("dbo.Detail", "ManufacturerId");
            DropColumn("dbo.Detail", "Price");
            DropColumn("dbo.Car", "ManufacturerId");
            DropTable("dbo.Manufacturer");
            CreateIndex("dbo.Car", "Detail_Id");
            AddForeignKey("dbo.Car", "Detail_Id", "dbo.Detail", "Id");
        }
    }
}
