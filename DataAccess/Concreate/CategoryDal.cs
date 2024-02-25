using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.DataAccess.Concreate
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "Programlama";
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            _categories.Remove(_categories[id]);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Update(Category category)
        {
            var data = _categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
        }
    }
}
