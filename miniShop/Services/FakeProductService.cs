using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    /// <summary>
    /// Database'e bağlanana kadar fake bir servis oluşturduk
    /// Bu metod veritabanı gibi davranacak
    /// Veriler veri tabanından geliyormuş gibi kullanılıcak
    /// EFcore ile bağlantı yapılana kadar
    /// </summary>
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{Id=1 ,Name="Saat", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat X", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat Y", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Örnek açıklama", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat Z", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Kol Saati", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Klasik Saat", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Spor Saat", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat X", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat Y", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Örnek açıklama", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat Z", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat D", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M,Discount=0.55,Rating=4},
                new Product{Id=1 ,Name="Saat Z", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M,Discount=0.55,Rating=4},
            };
        }
    }
}
