// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string Numberfirst = Convert.ToString(Number);
if (Numberfirst.Length > 2)
{
  Console.WriteLine(Numberfirst[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}
