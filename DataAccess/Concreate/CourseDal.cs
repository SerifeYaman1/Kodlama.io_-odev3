using Kodlama.io_Ödev3.DataAccess.Abstract;
using Kodlama.io_Ödev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Ödev3.DataAccess.Concreate
{
    public class CourseDal:ICourseDal
    {
        private List<Course> _courses;
        public CourseDal()
        {
            Course course1= new Course();
            course1.Id = 1;
            course1.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı(.NET)";
            course1.CourseDescription = string.Empty;
            course1.InstructorId = 1;
            course1.CategoryId = 1;

            Course course2= new Course();
            course2.Id = 2;
            course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı(C# + ANGULAR)";
            course2.CourseDescription = string.Empty;
            course2.InstructorId = 1;
            course2.CategoryId = 1;

            Course course3= new Course();
            course3.Id = 3;
            course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı- Python & Selenium";
            course3.CourseDescription = string.Empty;
            course3.InstructorId = 2;
            course3.CategoryId = 1;

            Course course4= new Course();
            course4.Id = 4;
            course4.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.CourseDescription = string.Empty;
            course4.InstructorId = 1;
            course4.CategoryId = 1;

            Course course5= new Course();
            course5.Id = 5;
            course5.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course5.CourseDescription = string.Empty;
            course5.InstructorId = 1;
            course5.CategoryId = 1;  
        }

        public void Add(Course course)
        {
            _courses.Add(course);
            
        }

        public void Delete(int id)
        {
            _courses.Remove(_courses[id]);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            var data = _courses.FirstOrDefault(c=> c.Id==course.Id);
            if (data != null) data = course;

        }
    }
}
