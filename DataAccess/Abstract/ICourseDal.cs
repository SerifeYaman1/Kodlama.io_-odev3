using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
        List<Course> GetAll();
        Course GetById(int id);
    }
}
