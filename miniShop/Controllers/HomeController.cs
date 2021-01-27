using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using miniShop.Services;

namespace miniShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService productService;
        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            //servis olarak ne gelirse onu otomatik alacak
            this.productService = productService;
        }

        public IActionResult Index(int page=1) //varsayılan page=1 
        {
           
            var products = productService.GetProducts();
            var pageSize = 4;

            // dinamik sayfalama
            var pagingProducts = products.OrderBy(p => p.Id)
                                         .Skip((page-1)*pageSize) //atlanacak satır-eleman sayısı
                                         .Take(pageSize);         //atladıktan sonra alınacak eleman sayısı
            /*
             * 1. sayfayı görmek için 0 atla(hiç atlamadan) page size kadar göster
             * 2. sayfa 4 atla 4 göster (gösterilen eleman pageSize)
             * 3. sayfada 8 atla 4 göster
             * . . .
             */

            //sayfalama işleminde bir sayfada kaç ürün göstereceğimizi belirledik
            //dinamik yaklaşım
            var totalProduct = products.Count; 
            var totalPage =Math.Ceiling((decimal) totalProduct / pageSize); //celing() yukarı yuvarla
            ViewBag.TotalPages = totalPage;


            //return View(products) eski hali, paging işlemi yaotıktan sonra PagingProducts'u return ettik
            return View(pagingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
