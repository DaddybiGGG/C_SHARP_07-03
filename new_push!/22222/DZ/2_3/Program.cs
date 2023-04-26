//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите чило от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 1 - 7)
{
    if (num <= 5)
    {
        Console.WriteLine("Работай");
    }
    else
        Console.WriteLine("Адыхай");
}
else
Console.WriteLine("Не балуйся");