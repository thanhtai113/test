namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class no2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Food_Dish", "SizeId", "dbo.Food_Size");
            DropForeignKey("dbo.Food_Dish", "TypeId", "dbo.Food_Type");
            DropIndex("dbo.Food_Dish", new[] { "TypeId" });
            DropIndex("dbo.Food_Dish", new[] { "SizeId" });
            AddColumn("dbo.Food_Dish", "Food_Size_Id", c => c.Int());
            AddColumn("dbo.Food_Dish", "Food_Type_Id", c => c.Int());
            AlterColumn("dbo.Food_Size", "name", c => c.String());
            AlterColumn("dbo.Food_Type", "nameType", c => c.String());
            CreateIndex("dbo.Food_Dish", "Food_Size_Id");
            CreateIndex("dbo.Food_Dish", "Food_Type_Id");
            AddForeignKey("dbo.Food_Dish", "Food_Size_Id", "dbo.Food_Size", "Id");
            AddForeignKey("dbo.Food_Dish", "Food_Type_Id", "dbo.Food_Type", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Food_Dish", "Food_Type_Id", "dbo.Food_Type");
            DropForeignKey("dbo.Food_Dish", "Food_Size_Id", "dbo.Food_Size");
            DropIndex("dbo.Food_Dish", new[] { "Food_Type_Id" });
            DropIndex("dbo.Food_Dish", new[] { "Food_Size_Id" });
            AlterColumn("dbo.Food_Type", "nameType", c => c.String(maxLength: 20));
            AlterColumn("dbo.Food_Size", "name", c => c.String(maxLength: 20));
            DropColumn("dbo.Food_Dish", "Food_Type_Id");
            DropColumn("dbo.Food_Dish", "Food_Size_Id");
            CreateIndex("dbo.Food_Dish", "SizeId");
            CreateIndex("dbo.Food_Dish", "TypeId");
            AddForeignKey("dbo.Food_Dish", "TypeId", "dbo.Food_Type", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Food_Dish", "SizeId", "dbo.Food_Size", "Id", cascadeDelete: true);
        }
    }
}
