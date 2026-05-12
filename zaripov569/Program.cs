var students = new List<Student>
{
    new(4.5f,"Anna","Ivanova",1),
    new(4.8f,"Alexsandr","Ivanov",2),
    new(4.5f,"Anna","Ivanova",4),
    new(4.2f,"Alexei","Zacharov",5),
    new(3.9f,"Anna","Melnikova",3),
    new(4.9f,"Michael","Foxyton",4),
    new(4.0f,"Inna","Ivanova",4),
    new(2.5f,"Michail","Ivanov",2),
    new(3.3f,"Anna","Ivanova",1),
    new(5.0f,"Alexei","Ivanov",3),
    new(2.5f,"Daniel","Ivanov",2),
    new(4.5f,"Anna","Sedokova",1),
    new(4.5f,"Alexsandra","Serduclova",4),    
};

//первое задание
var  byGradeFour = students.Where(s => s.Grade > 4);
foreach (var s in byGradeFour)
{
    Console.WriteLine($"оценка студента {s.Name} {s.Lastname}, {s.Course} - {s.Grade}");
}
//втрое задание
var grades= new[] {4.5,4.8,4.5,4.2,3.9,4.9,4.0,2.5,3.3,5.0,2.5,4.5,4.5};
Console.WriteLine($"у студентов средняя оценка {grades.Average()}");
// третье задание
// var sort =  students
//     .Where(s =>s.Grade)
//     .OrderBy(s =>s.Name)
//     .Select(s => s.Grade);
// foreach(var s in sort)
// 

var sort= students
    .Where(s => s.Grade > 4.5)
    .OrderBy(s => s.Name)
    .ThenBy(s => s.Lastname)
    .ThenBy(s => s.Course);
foreach(var s in sort)
{
    Console.WriteLine($"самые лучшие студенты и их данные: {s.Name},{s.Lastname},{s.Course},{s.Grade}");
}
//четвертое задание
var lazyStudents = students.Where(s => s.Grade < 3);
foreach(var s in lazyStudents)
{
    Console.WriteLine($"студенты которые не успевают: {s.Name}, {s.Lastname}, {s.Course} - {s.Grade}");
}

class Student(float Grade, string Name, string Lastname, int Course)
{
    public float Grade = Grade;
    public string Name = Name;
    public string Lastname = Lastname;
    public  int Course = Course;

}