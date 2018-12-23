namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class no1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstname = c.String(),
                        lastname = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        position = c.String(),
                        level = c.Int(nullable: false),
                        isLocked = c.Boolean(nullable: false),
                        imageURL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CusOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        numberDish = c.Int(nullable: false),
                        dateOrder = c.DateTime(nullable: false),
                        totalcost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Food_Dish",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        price = c.Double(nullable: false),
                        TypeId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                        imaGeURL = c.String(),
                        isLock = c.Boolean(nullable: false),
                        stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Food_Size", t => t.SizeId, cascadeDelete: true)
                .ForeignKey("dbo.Food_Type", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Food_Size",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Food_Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nameType = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderHistorys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        numberDish = c.Int(nullable: false),
                        dateOrder = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        positionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Food_Dish", "TypeId", "dbo.Food_Type");
            DropForeignKey("dbo.Food_Dish", "SizeId", "dbo.Food_Size");
            DropIndex("dbo.Food_Dish", new[] { "SizeId" });
            DropIndex("dbo.Food_Dish", new[] { "TypeId" });
            DropTable("dbo.Positions");
            DropTable("dbo.OrderHistorys");
            DropTable("dbo.Food_Type");
            DropTable("dbo.Food_Size");
            DropTable("dbo.Food_Dish");
            DropTable("dbo.CusOrders");
            DropTable("dbo.Accounts");
        }
    }
}
