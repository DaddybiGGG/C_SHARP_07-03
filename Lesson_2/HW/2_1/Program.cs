// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10;
}
// 123 / 10 -> 12
// 123 % 10 -> 3

int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);