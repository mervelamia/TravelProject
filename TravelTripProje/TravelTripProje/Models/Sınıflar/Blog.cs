using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlokImage { get; set; }
        public ICollection<Yorumlar>Yorumlars{get;set;} //Bloglar tablomuzla yorumlar tablomuzu bir çok ilişkisini oluşturur.
        //ICollection interfacetir. kümeleme listeleme işlemlerini yapar.
    }
}