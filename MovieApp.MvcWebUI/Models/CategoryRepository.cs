using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public class CategoryRepository
    {
        private static List<Category> categories = null;
        static CategoryRepository()
        {
            categories = new List<Category>()
           {
               new Category(){Id=1,Name="Kategori 1"},
               new Category(){Id=1,Name="Kategori 2"},
               new Category(){Id=1,Name="Kategori 3"},
               new Category(){Id=1,Name="Kategori 4"},
               new Category(){Id=1,Name="Kategori 5"},
               new Category(){Id=1,Name="Kategori 6"},
           };
        }

        public static List<Category> Categories
        {
            get { return categories; }
        }

        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(x => x.Id == id);

        }
    }
}
