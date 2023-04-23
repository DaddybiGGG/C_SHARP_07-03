//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Write a number 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 < num2)
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num1);
}  


