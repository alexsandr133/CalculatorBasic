using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = [];

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}


var salesFiles = FindFiles("stores");
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(Directory.GetCurrentDirectory());
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docPath);
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
// stores\201 на Windows
// stores/201 на macOS

Console.WriteLine(Path.Combine("stores", "201"));

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new(fileName);

Console.Write($"Full name: {info.FullName}{Environment.NewLine}");
Console.Write($"Directory: {info.Directory}{Environment.NewLine}");
Console.Write($"Create Date: {info.CreationTime}{Environment.NewLine}");


Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));
bool doesDirExists = Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));
Console.WriteLine(doesDirExists);

File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir", "greeting.txt"), "Hello!");

string readFile = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "sales.json"));
Console.WriteLine(readFile);
Console.WriteLine();

var salesData = JsonConvert.DeserializeObject<SalesTotal>(readFile);
Console.WriteLine(salesData.Total);


File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "stores", "totals.txt"), $"10000{Environment.NewLine}");


class SalesTotal
{
    public double Total;
}


// IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");
// IEnumerable<string> listOfFiles = Directory.EnumerateFiles("stores");
// IEnumerable<string> listOfFilteredFiles = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

// Console.WriteLine("Директории в \"stores\"");
// foreach (var dir in listOfDirectories)
// {
//     Console.WriteLine(dir);
// }

// Console.WriteLine("\n\nФайлы в \"stores\"");
// foreach (var file in listOfFiles)
// {
//     Console.WriteLine(file);
// }

// Console.WriteLine("\n\nФайлы в \"stores\" с фильтром \"*.txt\"");
// foreach (var file in listOfFilteredFiles)
// {
//     Console.WriteLine(file);
// }