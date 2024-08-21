// Öğrenciler ve sınıflar arasında group join işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin.

using LinqGroupJoin;

var classes = DataAccess.Classes;
var students = DataAccess.Students;

var classStudents = classes.GroupJoin(students, 
    @class => @class.Id,
    student => student.ClassId,
    (@class, students) => new
    {
        ClassName = @class.Name,
        Students = students
    });

foreach (var classStudent in classStudents)
{
    Console.WriteLine(classStudent.ClassName);
    foreach (var student in classStudent.Students)
    {
        Console.WriteLine(student.Name);
    }
    Console.WriteLine("----------------------");
}

