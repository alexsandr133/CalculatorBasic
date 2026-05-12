
var students = new List<Student>
{
  new("alexsandra","Zacharova",4.6,2),
  new("alexsandr","Zacharov",4.2,3),
  new("Michael","Foxyman",4.1,4),
  new("Michael","Grey",3.7,2),
  new("Michail","Foxyman",3.6,4),
  new("Pavel","Gromov",4.8,5),
  new("Michael","Greysenberg",4.4,1),
  new("Michael","Raimar",4.3,2),
  new("Olga","Zaripovf",4.7,3),
  new("Evgeniya","Foxyman",4.75,5),
  new("Michel","Foxyman",4.18,3),
  new("alexsandra","Foxyman",4.62,3),
  new("Sonya","Foxyman",4.68,1),
  new("Milana","Foxyman",4.88,3),
  new("Michael","Foxyman",4.97,5),
};
//первое задание выводим студентов второго курса
var studentsOnCourse = students
     .Where(s => s.Course == 2 )
     .OrderBy(s =>s.Name)
     .ThenBy(s => s.LastName);
     
foreach(var s in studentsOnCourse)
{
    Console.WriteLine($"студенты второго курса: {s.Name},{s.LastName},{s.Course} - {s.Grade}");
}
//второе задание оценки     
var grades = new[] {4.6,4.2,4.1,3.7,4.8,3.6,4.4,4.3,4.7,4.75,4.18,4.62,4.68,4.88,4.97};
Console.WriteLine($"Самая минимальная оценка {grades.Min()}");
Console.WriteLine($"медианная оценка {grades.Average()}");
Console.WriteLine($"Самая высокая оценка оценка {grades.Max()}");
//третье задание
var sorted = students
    .Where(s => s.Grade > 4.4)
    .OrderBy(s => s.LastName)
    .ThenBy(s => s.Name)
    //данный метод сортирует по убыванию
    .ThenByDescending(s => s.Grade);
foreach(var s in sorted)
{
    Console.WriteLine($"Лучшие студенты их данные: {s.Name} {s.LastName} {s.Course} - {s.Grade}");
}   
class Student(string Name, string LastName, double Grade, int Course)
{
    public  string Name = Name;
    public string LastName = LastName;
    public double Grade = Grade;
    public int Course= Course;


}