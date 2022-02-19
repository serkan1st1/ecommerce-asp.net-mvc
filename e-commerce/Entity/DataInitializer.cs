using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_commerce.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext> //modelde değişiklik varsa siler yeniden yükler.
    {
        protected override void Seed(DataContext context)
        {
            var ctgs = new List<Category>()
            {
                 new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                 new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                 new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                 new Category(){Name="Televizyon",Description="Televizyon Ürünleri"},
                 new Category(){Name="deneme",Description="deneme Ürünleri"},



            };
            foreach (var ctg in ctgs)
            {
                context.Categories.Add(ctg); //categories datacontext içinde
            }
            context.SaveChanges();


            var pducts = new List<Product>()
            {
                new Product(){Name="Apple iPhone 12 Pro Max 256GB Mavi Cep Telefonu",Description="Tüm akıllı telefon çiplerine açık ara fark atan A14 Bionic. Loş ışıkta çekilen fotoğrafları ileri bir seviyeye taşıyan Pro kamera sistemi. Bu seviyeyi zirve noktasına çıkaran iPhone 12 Pro Max. Ve düşmelere karşı dört kat daha iyi performans sunan Ceramic Shield. Gelin, tüm yeniliklere birlikte göz atalım.",Price=15000 , Stock=100 ,IsApproved=true ,CategoryId=1,Image="1_org.jpg",IsHome=true},
                new Product(){Name="Xiaomi Redmi Note 10 Pro 8GB + 128GB Gri Cep Telefonu",Description="Xiaomi Redmi Note 10 Pro, 6.67 inç ekran genişliğinin yanı sıra 1080x2400 piksel ekran çözünürlüğü sayesinde muhteşem görüntü kalitesine sahiptir. 8 GB RAM’i ile arka planda çalışan uygulamalar işinizi aksatmayacaktır. 128 GB ve arttırılabilir depolama alanı ile bütün bilgileriniz her zaman yanınızda olsun. 5020 mAh bataryası sayesinde de kesintisiz kullanabilme imkânı sunar.",Price=4800 , Stock=75 ,IsApproved=true ,CategoryId=1,IsHome=true,Image="tel.jpg"},
                new Product(){ Name = "Xiaomi Redmi Note 10S 64GB 6GB RAM Mavi Cep Telefonu – Xiaomi Türkiye Garantili",Description="Akıllı cep telefonu dünyasında adından sıkça söz ettiren ve kullanıcıların beğenisini kazanan Xiaomi, Note 10S modeliyle öne çıkıyor. Xiaomi Redmi serisinin sevilen akıllı telefon modeli, sahip olduğu özelliklerin yanı sıra tasarımıyla dikkat çekiyor. Hızlılık ve verimlilik sağlayan işlemcileriyle beğeni toplayan Xiaomi Redmi Note 10S, Android işletim sistemiyle ise kolay kullanıma sahip bir arayüz sunuyor.", Price =3500 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome=true,Image="tel.jpg"},
                new Product(){ Name = "Iphone 7 32 GB (Apple Türkiye Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =false , CategoryId = 1,IsHome=false,Image="tel.jpg"},

                new Product(){ Name = "Dell Inspiron 5567 Intel Core i5 7200U 8GB 1TB R7 M445 Windows 10 Home 15.6 FHD Taşınabilir Bilgisayar FHDG20W81C",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2,Image="3.jpg"},
                new Product(){ Name = "Lenovo Ideapad 310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10 Home 15.6 Taşınabilir Bilgisayar 80TV028XTX",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome=true,Image="tel.jpg"},
                new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome=true,Image="3.jpg"},
                new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 2,Image="3.jpg"},
                new Product(){ Name = "Asus N580VD-DM160T Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050 Windows 10 Home",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 2,Image="3.jpg"},

                new Product(){ Name = "Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3,Image="3.jpg"},
                new Product(){ Name = "kanon Eos 100D 18-55 mm DC Profesyonel Fotoğraf Makines",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3,IsHome=true,Image="3.jpg"},
                new Product(){ Name = "manon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 3,Image="3.jpg"},
                new Product(){ Name = "sanon Eos 100D 18-55 mm IS STM Kit DSLR Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3,Image="3.jpg"},
                new Product(){ Name = "hakon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 3,IsHome=true,Image="3.jpg"},


                new Product(){ Name = "LG 49UH610V 49 124 Ekran 4K Uydu Alıcılı Smart LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.",Price =1200 , Stock =500 , IsApproved =true , CategoryId = 4,Image="3.jpg"},
                new Product(){ Name = "Vestel 49UB8300 49 124 Ekran 4K Smart Led Tv",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 4,Image="3.jpg",IsHome=true},
                new Product(){ Name = "Samsung 55KU7500 55 140 Ekran [4K] Uydu Alıcılı Smart[Tizen] LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =4,IsHome=true,Image="3.jpg"},
                new Product(){ Name = "LG 55UH615V 55 140 Ekran 4K Uydu Alıcılı Smart Wi-Fi [webOS 3.0] LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 4,IsHome=true,Image="3.jpg"},
                new Product(){ Name = "Sony Kd-55Xd7005B 55 140 Ekran [4K] Uydu Alıcılı Smart LED TV",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 4,IsHome=true,Image="3.jpg"},



            };
            foreach (var pduct in pducts)
            {
                context.Products.Add(pduct);
            }
            context.SaveChanges();

            base.Seed(context);





        }

    }
}