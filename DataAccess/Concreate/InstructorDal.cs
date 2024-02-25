using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.DataAccess.Concreate
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;
        public InstructorDal() {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";
            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            _instructors.Remove(_instructors[id]);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return (Instructor)_instructors[id];
        }

        public void Update(Instructor instructor)
        {
            var data = _instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
        }
    }
}
