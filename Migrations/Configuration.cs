namespace MAEPacchi.Migrations
{
    using MAEPacchi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MAEPacchi.Models.BoxDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MAEPacchi.Models.BoxDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Boxes.AddOrUpdate(i => i.ID,
                new Box
                {
                    Sender = "DGAI-08",
                    Recipient = "DGSP-02",
                    Date = DateTime.Parse("1989-7-11"),
                    Note = "note",
                    Type = "Informatica",
                    Price = 7.99M
                },

                 new Box
                 {
                     Sender = "DGAI-07",
                     Recipient = "DGSP-05",
                     Date = DateTime.Parse("1989-2-11"),
                     Note = "note",
                     Type = "Mobili",
                     Price = 33.99M
                 },

                 new Box
                 {
                     Sender = "DGIT-02",
                     Recipient = "DGUE-06",
                     Date = DateTime.Parse("2021-5-11"),
                     Note = "note",
                     Type = "Informatica",
                     Price = 27.99M
                 },

                 new Box
                 {
                     Sender = "DGAI-08",
                     Recipient = "DGSP-02",
                     Date = DateTime.Parse("2022-1-11"),
                     Note = "note",
                     Type = "Mobili",
                     Price = 137.99M
                 }
            );
        }
    }
}
