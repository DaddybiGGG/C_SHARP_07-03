// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
Palindrom(number);
void Palindrom(int num)
{
    if (num / 10 / 10 / 10 / 10 % 10 == num % 10)
    {
        if (num / 10 / 10 / 10 % 10 == num / 10 % 10)
        {
            Console.WriteLine("палиндром");
        }
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}

