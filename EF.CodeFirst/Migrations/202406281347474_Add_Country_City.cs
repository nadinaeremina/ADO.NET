namespace EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Country_City : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCity = c.String(),
                        country_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.country_ID)
                .Index(t => t.country_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameCountry = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "country_ID", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "country_ID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
