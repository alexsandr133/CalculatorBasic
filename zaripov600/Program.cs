
Student s1 = new(5, "Egor");
Student s2 = new(3, "alexsandr");
Student s3 = new(3,"bob");
Student s4 = new(4, "alice");
Student s5 = new(5, "alice");
Student s6 = new(5, "alexsandra");
Student s7 = new(4, "alexei");
Student s8 = new(4, "mishel");

var students = new List<Student> {s1,s2,s3,s4,s5,s6,s7,s8};
var result = new List<string>();

foreach(var student in  students)
{
  if(student.Grade > 3)
    {
        result.Add(student.Name);
    }
}
result.Sort();
//сортировка с помощью foreach
foreach (var name in result)
{
    Console.WriteLine(name);
}
//сортировка
var names = students
  .Where(s => s.Grade >3)
  .OrderBy(s => s.Name)
  .Select(s => s.Name);

var result1 = from s in students
              where s.Grade > 3
              orderby s.Name
              select s.Name;

// коллекция чисел
var numbers = new List<int> {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30};
//сортировка чисел признак число больше двух 
var query = numbers.Where(n => n > 2);
numbers.Add(10);
foreach (var n in query)
{
    Console.WriteLine(n);
}
class Student(int Grade, string Name)
{
    public int Grade = Grade;
    public string Name = Name;
}
