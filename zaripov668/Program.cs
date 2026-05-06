using System.Diagnostics.CodeAnalysis;
using System.Globalization;
//выводим день
DateTime now = DateTime.Now;
DayOfWeek day = now.DayOfWeek;
//следующее вочкресенье
Console.WriteLine($"Today is {day}");
DateTime nextSunday = now.AddDays(7 - (int)day);
Console.WriteLine($"Следвующиее воскресеньте: {nextSunday}");

TimeSpan restDays =  nextSunday - now;
Console.WriteLine($"Следвующиее воскресеньте: {nextSunday}");

bool isWeekend = day == DayOfWeek.Sunday || day == DayOfWeek.Saturday;
if (isWeekend)
{
    Console.WriteLine("Сегодня выходной");
}
else
{
    Console.WriteLine("Не выходной день сегодня");
}
CultureInfo currentCulture = CultureInfo.CurrentCulture;
CultureInfo currentUICulture = CultureInfo.CurrentCulture;

Console.WriteLine(currentCulture.Name);
Console.WriteLine(currentCulture.NativeName);

CultureInfo newCulture = new("fr-FR");
Console.WriteLine(newCulture);

Calendar calendar = CultureInfo.InvariantCulture.Calendar;
int daysInMonth = calendar.GetDaysInMonth(2023,2);
Console.WriteLine($"Дней в феврале 2023: {daysInMonth}");

DateTime date2 = new(2023, 12, 31);
CalendarWeekRule rule= CalendarWeekRule.FirstDay;
DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
int weekOfYear = calendar.GetWeekOfYear(date2, rule, firstDayOfWeek);
Console.WriteLine("номер недели 31 декабря 2023 " + weekOfYear);

TimeOnly  meetingTime =  new(14, 30);
Console.WriteLine($"Meetings time: {meetingTime}");