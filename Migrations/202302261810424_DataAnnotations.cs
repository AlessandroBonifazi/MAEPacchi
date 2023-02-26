namespace MAEPacchi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Boxes", "Sender", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Boxes", "Recipient", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Boxes", "Type", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Boxes", "Type", c => c.String());
            AlterColumn("dbo.Boxes", "Recipient", c => c.String());
            AlterColumn("dbo.Boxes", "Sender", c => c.String());
        }
    }
}
