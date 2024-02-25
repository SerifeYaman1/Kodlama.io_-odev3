using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetById(int id);
    }
}
