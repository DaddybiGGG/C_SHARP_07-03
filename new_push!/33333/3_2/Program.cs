// 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Write X: ");

int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write Y: ");

int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
else
{
    Console.WriteLine("Данные не верны");
}