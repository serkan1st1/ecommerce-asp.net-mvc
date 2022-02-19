using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_commerce.Entity;

namespace e_commerce.Models
{
    public class Cart
    {
        //Alışveriş sepetinin tamamı
        private List<CartLine> _cartLines = new List<CartLine>();

        public List<CartLine> CartLines
        {

            get { return _cartLines; }

        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line==null)
            {
                //Ürün sepette yoksa önce sepete ekleriz sonrra eklenen adet miktarı kadar ekleriz
                _cartLines.Add(new CartLine(){Product = product,Quantity = quantity});
            }
            else
            {
                //Sepette ürün ekli ise eklenen miktar kadar artar
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double Total()
        {
            return _cartLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cartLines.Clear();
        }
    }

    public class CartLine
    { 
        //Sadece 1 ürün
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}