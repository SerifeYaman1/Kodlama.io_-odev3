using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.Business.Constant
{
    public class CategoryManager : ICategoryDal
    {
        private readonly ICategoryDal _service;
        public CategoryManager(ICategoryDal service)
        {
            _service = service;
        }

        public void Add(Category category)
        {
            _service.Add(category);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _service.GetAll();
        }

        public Category GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Category category)
        {
            _service.Update(category);
        }
    }
}
