// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Write a number 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number 2: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number 3: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num3);
}