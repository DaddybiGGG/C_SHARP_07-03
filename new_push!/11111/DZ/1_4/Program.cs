// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine()!);

count = 1;

if (num < count)
{
    Console.Write(count);
    count++;
}