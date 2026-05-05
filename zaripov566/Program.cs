using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Newtonsoft.Json;



IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = [];

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    foreach (var file in foundFiles)
    {    var extension = Path.GetExtension(file);
         if(extension == ".json")
        {
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}

var salesFiles = FindFiles("stores");
foreach(var file in salesFiles)
{
    Console.WriteLine(file);
}
Console.WriteLine();
Console.WriteLine();
//вывод директории
Console.WriteLine(Directory.GetCurrentDirectory());
//вывод директории с документами
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docPath);

Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
//stores\201 на Windows
// stores/201 на macOs
//метод combine для разбиенения
Console.WriteLine(Path.Combine("stores", "201"));

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json";

//узнаем инфломацию о файле
FileInfo info = new(fileName);
Console.Write($"Full name: {info.FullName}{Environment.NewLine}");
Console.Write($"Directory:{info.Directory}{Environment.NewLine}");
Console.WriteLine($"Create Date {info.CreationTime}{Environment.NewLine}");
//узнаем существует ли данная директория
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(),"stores","201","newDir"));
bool  doesDirExists = Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));
Console.WriteLine(doesDirExists);
//запись текста в файл
File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir","greeting.txt"), "hello Michael");
//считывание файла
string fileRead =  File.ReadAllText (Path.Combine(Directory.GetCurrentDirectory(), "stores","201","sales.json"));
Console.WriteLine(fileRead);
Console.WriteLine();

var salesData = JsonConvert.DeserializeObject<SalesTotal>(fileRead);
Console.WriteLine(salesData.Total);

File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(),"totals.txt"), $"10000{Environment.NewLine}");
class SalesTotal
{
    public double Total;
}