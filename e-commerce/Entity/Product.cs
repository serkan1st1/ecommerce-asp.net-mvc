using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace e_commerce.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        [DisplayName("Anasayfa")]
        public bool IsHome { get; set; }
        [DisplayName("Görünüm")]
        public bool IsApproved { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }

        public int CategoryId  { get; set; }
    
        public Category Category { get; set; }  //bir ürün bir kategoriye ait

        
       
    }
}