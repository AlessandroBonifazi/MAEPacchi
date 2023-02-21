using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MAEPacchi.Models
{
    public class Pacco
    {
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
    }
    public class PaccoDBContext : DbContext
    {
        public DbSet<Pacco> Pacchi { get; set; }
    }
}