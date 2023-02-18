using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Entity;

namespace MAEPacchi.Models
{
    public class Pacco
    {
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
    }
    //public class MovieDBContext : DbContext
    //{
    //    public DbSet<Movie> Movies { get; set; }
    //}
}