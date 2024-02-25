using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.Business.Constant
{
    public class InstructorManager : IInstructorDal
    {
        private readonly IInstructorDal _service; 
        public InstructorManager(IInstructorDal service)
        {
            _service = service;
        }

        public void Add(Instructor instructor)
        {
            _service.Add(instructor);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _service.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Instructor instructor)
        {
            _service.Update(instructor);
        }
    }
}
