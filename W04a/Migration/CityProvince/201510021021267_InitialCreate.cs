namespace W04a.Migration.CityProvince
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        ProvinceId = c.Int(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 30),
                        Population = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "ProvinceId", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "ProvinceId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
