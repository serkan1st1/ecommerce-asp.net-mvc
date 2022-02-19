using System;
using System.Collections.Generic;
using System.ComponentModel; //List collections türündendir.
using System.Linq;
using System.Web;

namespace e_commerce.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori")]
        public string Name { get; set; }

        
        public string Description { get; set; }
        public List<Product> Products { get; set; } //Bir kategori birden fazla üründe yer alabilir. List collectionsdır.

        //Bir categoride birden fazla ürün bulunabilir demek.


    }
}