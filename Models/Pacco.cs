using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MAEPacchi.Models
{
    public class Box
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string Sender { get; set; }

        [Required,StringLength(50, MinimumLength = 3)]
        public string Recipient { get; set; }

        [Display(Name = "Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Note { get; set; }

        [Required,RegularExpression(@"^[A-Z]+[a-zA-Z]*$"),StringLength(30)]
        public string Type { get; set; }

        [Range(1, 1000),DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
    public class BoxDBContext : DbContext
    {
        public DbSet<Box> Boxes { get; set; }
    }
}