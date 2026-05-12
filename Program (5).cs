Student s1 = new(5, "Egor", "Smirnov", 1);
Student s2 = new(3, "Leonid", "Ivanov", 1);
Student s3 = new(2, "Bob", "Bob", 2);
Student s4 = new(4, "Alice", "Alice", 2);
Student s5 = new(5, "Bob", "Bob", 3);

var students = new List<Student> {s1, s2, s3, s4, s5};
// var result = new List<string>();

// foreach (var student in students)
// {
//     if (student.Grade > 3)
//     {
//         result.Add(student.Name);
//     }
// }

// var result = from s in students
//              where s.Grade > 3
//              orderby s.Name
//              select s.Name;

var names = students
    .Where(s => s.Grade > 3)
    .OrderBy(s => s.Name)
    .Select(s => s.Name);

var byName = students.OrderBy(s => s.LastName);
var byGradeDesc = students.OrderByDescending(s => s.Grade);

var sorted = students
    .OrderBy(s => s.LastName)
    .ThenBy(s => s.Name)
    .ThenByDescending(s => s.Grade);

// result.Sort();

var byCourse = students.GroupBy(n => n.Course);

foreach (var group in byCourse)
{
    Console.WriteLine($"{group.Key} курс");
    foreach (var s in group)
    {
        Console.WriteLine($"{s.Name} {s.LastName} - {s.Grade}");
    }
}



var grades = new[] {4, 5, 3, 2, 5, 4, 5};

Console.WriteLine($"Количество элементов: {grades.Count()}");
Console.WriteLine($"Сумма: {grades.Sum()}");
Console.WriteLine($"Самая низкая оценка: {grades.Min()}");
Console.WriteLine($"Самая высокая оценка: {grades.Max()}");
Console.WriteLine($"Средняя оценка: {grades.Average()}");

var ffGrades = grades.Count(g => g >= 4);

var firstFive = grades.First(g => g == 5);
var firstTwo = grades.FirstOrDefault(g => g == 2);
var firstFour = grades.LastOrDefault(g => g == 4);

var top3 = grades.Take(3);
var skip3 = grades.Skip(3);

bool hasExcellent = grades.Any(g => g == 5);    // true
bool allPassed = grades.All(g => g >= 3);       // false
bool contains2 = grades.Contains(2);









// foreach (var student in sorted)
// {
//     Console.WriteLine($"{student.Name} {student.LastName} - {student.Grade}");
// }


var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

var query = numbers.Where(n => n > 2);
var even = numbers.Where(n => n % 2 == 0);
var evenInd = numbers.Where((index, n) => n % 2 == 0);

// foreach (var n in evenInd)
// {
//     Console.WriteLine(n);
// }


var words = new[] {"apple", "banana", "cherry"};

var lengths = words.Select(n => n.Length);
foreach(var l in lengths)
{
    Console.WriteLine(l);
}



// numbers.Add(10);

// foreach (var n in query)
// {
//     Console.WriteLine(n);
// }



class Student(int Grade, string Name, string LastName, int Course)
{
    public int Grade = Grade;
    public string Name = Name;
    public string LastName = LastName;
    public int Course = Course;
}