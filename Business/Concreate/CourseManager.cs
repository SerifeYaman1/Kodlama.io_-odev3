using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.Business.Constant
{
    public class CourseManager : ICourseDal
    {
        private readonly ICourseDal _service;
        public CourseManager(ICourseDal service)
        {
            _service = service;
        }

        public void Add(Course course)
        {
            _service.Add(course);   
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _service.GetAll();
        }

        public Course GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Course course)
        {
            _service.Update(course);
        }
    }
}
