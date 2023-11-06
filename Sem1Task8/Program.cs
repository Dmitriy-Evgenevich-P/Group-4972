// Программа показывает все чётные числа от 1 до n.

static void Main()
{
Console.WriteLine("Введите длину: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);
}
        



// Программа выводит выводит числа от -n до n

// int a = int.Parse(Console.ReadLine());
// if (a < 0) a = -a;
// for(int i = -a; i <= a; i++)
// {
//     Console.Write(i);
//     Console.Write(" ");
// }
// Нет запятых


// int N = int.Parse(Console.ReadLine()??"0");
// int minusN = -N;
// for(int i = -N; i <= N; i++)
// {
//     Console.Write(i.ToString()+ " ");
// }
// Нет запятых



// int NumN = int.Parse(Console.ReadLine()??"0");
// int evNumN = (-1)*NumN;
// while (evNumN < NumN)
// {
//    Console.Write (evNumN + ", ");
//    evNumN++;
// }
//   Console.WriteLine (NumN);