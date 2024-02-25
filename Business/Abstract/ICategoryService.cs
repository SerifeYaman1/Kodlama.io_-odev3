using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
