using FORMACIM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FORMACIM.Context
{
    public class MyInitializer:CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
             new Category(){Name="Forma",Description="Üst Forma Ürünleri"},
             new Category(){Name="Şort",Description="Alt Takım Ürünleri"},
             new Category(){Name="Krampon",Description="Ayakkabı Ürünleri"},

            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            var urunler = new List<Product>()
            { new Product(){Name="Galatasaray Ev Sahibi Forması",Description="Galatasaray'ın 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez forma",Price=500,stock =500,IsApproved=true,CategoryId=1,IsHome=true,Image="1.png"},
             new Product(){Name="Fenerbahçe Ev Sahibi Forması",Description="Fenerbahçe'nin 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez forma",Price=500,stock =500,IsApproved=true,CategoryId=1,IsHome=true,Image="2.jpg"},
             new Product(){Name="Beşiktaş Ev Sahibi Forması",Description="Beşiktaş'ın 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez forma",Price=500,stock =500,IsApproved=true,CategoryId=1,IsHome=true,Image="3.jpg"},
             new Product(){Name="Trabzonspor Ev Sahibi Forması",Description="Trabzonspor'un 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez forma",Price=500,stock =500,IsApproved=true,CategoryId=1,IsHome=true,Image="4.jpg"},

             new Product(){Name="Galatasaray Şortu ",Description="Galatasaray'ın 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez şort",Price=250,stock =100,IsApproved=true,CategoryId=2,IsHome=true,Image="5.jpg"},
             new Product(){Name="Fenerbahçe Şortu",Description="Fenerbahçe'nin 2022-2023 sezonunda kendi sahasında giydiği %100 polyester yapımı terletmez ve su geçirmez forma",Price=250,stock =100,IsApproved=true,CategoryId=2,IsHome=true,Image="6.jpg"},

             new Product(){Name="Siyah Altın Krampon",Description="Altın renkli %100 orijinal yüksek ayak bileği Futbol ayakkabısı",Price=4500,stock =250,IsApproved=true,CategoryId=3,IsHome=true,Image="7.jpg"},
             new Product(){Name="Nike Mavi Krampon",Description="Nike yeni sezon Futbol kramponu",Price=3000,stock =250,IsApproved=true,CategoryId=3,IsHome=true,Image="8.jpg"}
             

            };
            context.Products.AddRange(urunler);
            context.SaveChanges();
        }
    }
}
