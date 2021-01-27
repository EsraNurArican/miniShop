using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    /// <summary>
    /// Geçici  category services classı
    /// Proje henüz bir database'e bağlanmadığı için bu class categorileri temsil etmek üzere tasarlandı.
    /// </summary>
    public class FakeCategoryServices : ICategoryService
    {
       
        IList<Category> ICategoryService.GetCategories()
        {
            return new List<Category>
            {
                new Category{Id=1,Name="Aksesuar" },
                new Category{Id=2,Name="Ayakkabı"},
                new Category{Id=3,Name="Saat"}
            };
            
        }
    }
}
