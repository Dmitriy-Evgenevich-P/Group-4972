
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 3:");
int num3 = int.Parse(Console.ReadLine() ?? "0");

if (num1 > num2)
{
   if (num1 > num3)
   {
      Console.WriteLine("максимальное число:" + num1);
   }
   else
   {
      Console.WriteLine("максимальное число:" + num3);
   }
}
else
{
   if (num2 > num3)
   {
      Console.WriteLine("максимальное число:" + num2);
   }
   else 
   {
      Console.WriteLine("максимальное число:" + num3);
   }
}