
using System.Text.RegularExpressions;

var students = new List <Student>
{
    new(1,"Michael","Foxyman",22,"developers_software",4.1,5),
    new(2,"Alexsandra","Melikova",27,"developers_software",4.4,5),  
    new(3,"Michel","Foxyman",19,"developers_software",4.6,4),
    new(4,"Alexsandr","Zaripov",18,"developers_software",4.9,3),
    new(5,"Oleg","Foxyman",16,"grahics_design",4.31,1),
    new(6,"Olga","Petrova",18,"grahics_design",4.45,3),
    new(7,"Dmytryi","Petrov",16,"grahics_design",3.88,1),
    new(8,"Oleg","Petrov",15,"grahics_design",3.55,1),
    new(9,"Amirkhan","Kerimov",17,"grahics_design",4.96,1),
    new(10,"Daniel","Petrov",17,"management",4.07,1),
    new(11,"Ashab","Merzoev",16,"management",4.95,1),
    new(12,"Adriama","Lima",16,"grahics_design",4.99,1),
    new(13,"Alikahn","Merzoev",35,"ML_learning",4.75,5),
    new(14,"Elizveta","Petrova",38,"ML_learning",4.96,5),
    new(15,"Olga","Petrova",30,"management",4.88,5),
    new(16,"Timur","Ivanov",36,"management_Seo",5.0,5),
    new(17,"Olga","Petrova",16,"grahics_design",4.35,1),
    new(18,"Olga","Petrova",16,"grahics_design",4.98,1),
    new(19,"Oleg","Vinesmokingov",16,"grahics_design",4.22,1),
    new(20,"Olga","Petrova",15,"grahics_design",4.82,1),
 
};
//первое задание
void SortedStudentsAge()
{
  var sortedAge = students
   .Where(s => s.Age > 20)
   .OrderBy(s => s.FullName)
   .ThenBy(s => s.Lastname)
   .ThenBy(s => s.AverageGrade);
   foreach(var s in sortedAge)
    {
        Console.WriteLine($"студенты старше 20 лет инофрмация про них: {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} - {s.AverageGrade}");
    }   
}
//второе задание
void SortedStudent()
{
    var sortedAverageGrade = students
      .Where(s =>s.AverageGrade > 4.5)
      .OrderBy(s => s.FullName)
      .ThenBy(s => s.Lastname) 
      .ThenBy(s => s.AverageGrade)
      .ThenBy(s => s.Course)
      .ThenBy(s => s.Group)
      .ThenBy(s => s.Id);
    foreach(var s in sortedAverageGrade)
    {
      Console.WriteLine($"студенты у которых оценка выше 4.5 {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} {s.Id} - {s.AverageGrade}");   
    }  
       
}
//третье
void sortedNames()
{
     var sortedNames = students
      .OrderBy(s => s.FullName)
      .ThenBy(s => s.Lastname)
      .ThenBy(s => s.AverageGrade)
      .ThenBy(s => s.Course)
      .ThenBy(s => s.Id);
      foreach(var s in sortedNames)
    {
      Console.WriteLine($"все студенты  {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} {s.Id} - {s.AverageGrade}");   
    }
}
//четвертое
void sortedAge()
{
    var sortedNames = students
      .OrderBy(s => s.Age)
      .ThenBy(s => s.Lastname)
      .ThenBy(s=> s.FullName)
      .ThenBy(s => s.AverageGrade)
      .ThenBy(s => s.Course)
      .ThenBy(s => s.Id);
      foreach(var s in sortedNames)
    {
      Console.WriteLine($"все студенты  {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} {s.Id} - {s.AverageGrade}");   
    }
}
//пятое задание
void sortedAverageGrade()
{
    var sortedNames = students
      .OrderBy(s => s.Age)
      .ThenBy(s => s.Lastname)
      .ThenBy(s=> s.FullName)
      .ThenBy(s => s.AverageGrade)
      .ThenBy(s => s.Course)
      .ThenByDescending(s => s.AverageGrade)
      .ThenBy(s => s.Id);
      foreach(var s in sortedNames)
    {
      Console.WriteLine($"все студенты  {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} {s.Id} - {s.AverageGrade}");   
    }
}
//шестое задание
void responseName()
{
    var names = students
       .Where(s => s.AverageGrade > 4.1)
       .OrderBy(s => s.Lastname)
       .ThenBy(s => s.FullName);
    foreach(var s in names)   
    {
      Console.WriteLine($"все студенты  {s.FullName}");   
    }      
}
//седьмое
void responseAverageGrade()
{
    var sortedNames = students
      .OrderBy(s => s.Age)
      .ThenBy(s => s.Lastname)
      .ThenBy(s=> s.FullName)
      .ThenBy(s => s.AverageGrade)
      .ThenBy(s => s.Course)
      .ThenByDescending(s => s.AverageGrade)
      .ThenBy(s => s.Id);
      foreach(var s in sortedNames)
    {
      Console.WriteLine($"все студенты  {s.FullName} {s.Age} {s.Lastname} {s.Group} {s.Course} {s.Id} - {s.AverageGrade}");   
    }
}
//восьмое
void sortedByGroup()
{
   var sortedByGroup = students.GroupBy(n => n.Group);
   foreach (var Group  in sortedByGroup )
   {
        Console.WriteLine($"{Group} группа");
        foreach (var s  in Group)
        {
            Console.WriteLine($"{s.FullName} {s.Group} {s.AverageGrade} {s.Course} {s.Id}");
        }    
   }
}
void ReturnInformation()
{
    Console.WriteLine($"количество элементов: {students.Count()}");
}
// void ReturnAverage()
// {
//     var grades = students
//      .Where(s=>s.AverageGrade > 4.1)
//      .OrderBy(s => s.FullName)
//      .ThenBy(s => s.Lastname)
//      .ThenBy(s => s.Course)
//      .ThenBy(s => s.Course)
//      .ThenBy(s => s.Id)
//      .Select(s => s.AverageGrade);
//     foreach(var s in grades)
//     {
//       Console.WriteLine($"все студенты  {s.AverageGrade}");   
//     }
     


// void ReturnAverageGrade()
// {
//      Console.WriteLine($"средний балл студентов {students.AverageGrade()}");
// }

sortedAge();
responseName();
ReturnInformation();
sortedAverageGrade();
SortedStudent();
sortedNames();
SortedStudentsAge();
sortedByGroup();
responseAverageGrade();
FindStudents();
//поиск
void FindStudents()
{
  var first = students.First(s => s.Age < 18);
  bool studentsThree = students.All(s => s.AverageGrade > 3.55);
  Console.WriteLine(studentsThree);
}
class Student(int Id, string FullName,string Lastname, int Age, string Group,  double AverageGrade,int Course)
{
     public int Id = Id;
     public string FullName = FullName;
     public string Lastname = Lastname;
     public int Age = Age;
     public string Group = Group;
     public double AverageGrade = AverageGrade;

     public int Course = Course;
}