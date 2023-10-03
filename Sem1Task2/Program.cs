Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 > num2)

{     Console.WriteLine("first number - max, second number - min");
}
else
{
    Console.WriteLine("first number - min, second number - max");
 }

