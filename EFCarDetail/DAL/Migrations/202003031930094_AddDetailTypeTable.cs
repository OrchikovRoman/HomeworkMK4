namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetailTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO dbo.DetailTypes(NAME) VALUES ('NOT SELECTED')");
            

            AddColumn("dbo.Car", "Detail_Id", c => c.Int());
            AddColumn("dbo.Detail", "DetailTypeId", c => c.Int(nullable: false));
            Sql("UPDATE dbo.Detail SET DetailTypeId=1 WHERE DetailTypeId=0");
            CreateIndex("dbo.Car", "Detail_Id");
            CreateIndex("dbo.Detail", "DetailTypeId");
            AddForeignKey("dbo.Detail", "DetailTypeId", "dbo.DetailTypes", "Id");
            AddForeignKey("dbo.Car", "Detail_Id", "dbo.Detail", "Id");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Car", "Detail_Id", "dbo.Detail");
            DropForeignKey("dbo.Detail", "DetailTypeId", "dbo.DetailTypes");
            DropIndex("dbo.Detail", new[] { "DetailTypeId" });
            DropIndex("dbo.Car", new[] { "Detail_Id" });
            DropColumn("dbo.Detail", "DetailTypeId");
            DropColumn("dbo.Car", "Detail_Id");
            DropTable("dbo.DetailTypes");
        }
    }
}
