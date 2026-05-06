using System.Globalization;

TimeOnly meetingTime = new(14, 30);
Console.WriteLine($"Meeting time: {meetingTime}");

TimeSpan duration = new(2, 0, 0);
Console.WriteLine($"Duration: {duration}");

DayOfWeek today = DateTime.Now.DayOfWeek;
Console.WriteLine($"Today is {today}");

// DateTimeOffset now = DateTimeOffset.Now;
// Console.WriteLine($"Со смещением: {now}");

DateTimeOffset UtcNow = DateTimeOffset.UtcNow;
Console.WriteLine($"UTC: {UtcNow}");

// DateTimeOffset futureDate = now.AddDays(10);
// Console.WriteLine($"Дата через 10 дней: {futureDate}");

// DateTimeOffset pastDate = now.AddHours(-10);
// Console.WriteLine($"Дата и время 10 часов назад: {pastDate}");

DateTime dateTime = DateTime.UtcNow;
Console.WriteLine($"Дата и время: {dateTime}");

// DateTime estNow = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "Eastern Standart Time");
// Console.WriteLine($"Дата и время EST: {estNow}");

TimeZoneInfo localZone = TimeZoneInfo.Local;
Console.WriteLine($"Local time zone: {localZone.DisplayName}");

TimeSpan duration1 = new(2, 14, 10);
Console.WriteLine(duration1);

TimeSpan fromDays = TimeSpan.FromDays(2.5);
Console.WriteLine(fromDays);

TimeSpan fromHours1 = TimeSpan.FromHours(5.75);
Console.WriteLine(fromHours1);


TimeSpan fromHours2 = TimeSpan.FromHours(3.75);
Console.WriteLine(fromHours2);


TimeSpan difference = fromHours1 - fromHours2;
difference *= 10;
Console.WriteLine(difference);

DateTime now = DateTime.Now;
DayOfWeek day = now.DayOfWeek;

Console.WriteLine($"Today is {day}");

DateTime nextSunday = now.AddDays(7 - (int)day);
Console.WriteLine($"Следующее воскресенье: {nextSunday}");

TimeSpan restDays = nextSunday - now;
Console.WriteLine($"Дней до воскресенья: {restDays}");

bool isWeekend = day == DayOfWeek.Sunday || day == DayOfWeek.Saturday;
if (isWeekend)
{
    Console.WriteLine("Сегодня выходной");
}
else
{
    Console.WriteLine("Сегодня не выходной");
}

CultureInfo currentCulture = CultureInfo.CurrentCulture;
CultureInfo currentUICulture = CultureInfo.CurrentUICulture;

Console.WriteLine(currentCulture.Name);
Console.WriteLine(currentUICulture.NativeName);

CultureInfo newCulture = new("fr-FR");
Console.WriteLine(newCulture.NativeName);

Calendar calendar = CultureInfo.InvariantCulture.Calendar;
int daysInMonth = calendar.GetDaysInMonth(2023, 2);
Console.WriteLine($"Дней в феврале 2023: {daysInMonth}");

DateTime date2 = new(2023, 12, 31);
CalendarWeekRule rule = CalendarWeekRule.FirstDay;
DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
int weekOfYear = calendar.GetWeekOfYear(date2, rule, firstDayOfWeek);
Console.WriteLine("Номер недели 31 Декабря 2023 " + weekOfYear);