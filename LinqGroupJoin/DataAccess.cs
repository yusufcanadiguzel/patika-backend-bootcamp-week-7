using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    internal class DataAccess
    {
        public static List<Student> Students { get; set; }
        public static List<Class> Classes { get; set; }

        static DataAccess() 
        {
            Students = new List<Student>()
            {
                new Student(id: 1, name: "Ali", classId: 1),
                new Student(id: 2, name: "Ayşe", classId: 2),
                new Student(id: 3, name: "Mehmet", classId: 1),
                new Student(id: 4, name: "Fatma", classId: 3),
                new Student(id: 5, name: "Ahmet", classId: 2),
            };

            Classes = new List<Class>()
            {
                new Class(id: 1, name: "Matematik"),
                new Class(id: 2, name: "Türkçe"),
                new Class(id: 3, name: "Kimya")
            };
        }
    }
}
