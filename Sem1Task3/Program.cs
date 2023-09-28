// int day = int.Parse(Console.ReadLine()??"0");

// string[] dayOfweek = new string[7];

// dayOfweek[0]="Понедельник";
// dayOfweek[1]="Вторник";
// dayOfweek[2]="Среда";
// dayOfweek[3]="Четверг";
// dayOfweek[4]="Пятница";
// dayOfweek[5]="Суббота";
// dayOfweek[6]="Воскресенье";

// Console.WriteLine(dayOfweek[day-1]);

Console.WriteLine("Enter day number");
int dayNum = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));

Console.WriteLine(outDayOfWeek);