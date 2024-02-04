using Bootcamp_1.Gün.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_1.Gün.bussines
{
    public class CourseManager
    {
        Course[] courses;
        public CourseManager()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = "C# kursu";

            Course course2 = new Course();
            course2.Id = 1;
            course2.Name = "Python";
            course2.Description = "python kursu";

           

        }
        public void GetAll()
        {
            Console.WriteLine("Kurslar Listelendi");
        }
    }
}
