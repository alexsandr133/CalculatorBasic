// See https://aka.ms/new-console-template for more information
using System.Drawing;

Point a;     
a.X = 3.7;
a.Y = 4.7;
double result = a.toStartPoint();
Console.WriteLine(result);

WeekDays today = WeekDays.monday;
Console.WriteLine((int)today);
switch(today)
{
    case WeekDays.satursday:
    case WeekDays.sunday:
     Console.WriteLine("выхожной");
     break;
    default:
     Console.WriteLine("будний день");
     break; 
}

struct Point
{
     public double X;
     public double Y;

     public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double toStartPoint()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

enum WeekDays
{
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    satursday,
    sunday
}
enum CodeAnswer
{
    Success = 200,
    NotFound = 404,
    ServerError = 500
}
[Flags]

enum rights   
{
    noRights = 0, //000
    read = 1,    //001
    write =2,   //010
    delete = 4, //100
}