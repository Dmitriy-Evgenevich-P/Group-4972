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




// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());

// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));

// Console.WriteLine(outDayOfWeek);




// System.Console.WriteLine("Введите номер");
// int a = Convert.ToInt32 (Console.ReadLine());
// switch (a)
// {
//    case 1: Console.WriteLine ("Пн");
//    break;

//    case 2: Console.WriteLine ("Вт");
//    break;

//    case 3: Console.WriteLine ("Ср");
//    break;

//    case 4: Console.WriteLine ("Чт");
//    break;

//    case 5: Console.WriteLine ("Пт");
//    break;

//    case 6: Console.WriteLine ("Сб");
//    break;

//    case 7: Console.WriteLine ("Вс");
//    break;
// Не хватает дополнения, если будет 8.



// string day = Console.ReadLine()??"0";

// switch (day)
// {
//     case "1": Console.WriteLine("Понедельник"); break;
//     case "2": Console.WriteLine("Вторник"); break;
//     case "3": Console.WriteLine("Среда"); break;
//     case "4": Console.WriteLine("Четверг"); break;
//     case "5": Console.WriteLine("Пятница"); break;
//     case "6": Console.WriteLine("Суббота"); break;
//     case "7": Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Неверные данные"); break;
// }



Console.WriteLine("Enter day number");
int dayNum = int.Parse(Console.ReadLine());


if(dayNum == 1){
	Console.WriteLine("Monday");
}
else if(dayNum == 2){
	Console.WriteLine("Tuesday");
}
else if(dayNum == 3){
	Console.WriteLine("Wednesday");
}
else if(dayNum == 4){
	Console.WriteLine("Thursday");
}
else if(dayNum == 5){
	Console.WriteLine("Friday");
}
else if(dayNum == 6){
	Console.WriteLine("Saturday");
}
else if(dayNum == 7){
	Console.WriteLine("Sunday");
}
else {
	Console.WriteLine("Not day of week");
}