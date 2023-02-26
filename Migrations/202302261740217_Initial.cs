namespace MAEPacchi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Sender = c.String(nullable: false),
                        Recipient = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        Type = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Boxes");
        }
    }
}
