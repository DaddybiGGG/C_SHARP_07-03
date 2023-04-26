// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10, 1000);
Console.WriteLine(num);
if (num <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
while (num > 999) num /= 10;
{
    if (num <= 999)
    {
        num % 10;
        return num;
    }
}
Console.WriteLine(num);
