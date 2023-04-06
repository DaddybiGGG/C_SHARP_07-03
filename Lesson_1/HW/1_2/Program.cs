int max = 0;

Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 3 число: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    max = num1;
}
else if (num2 > num3)
{
    max = num2;
}
else if (num3 > num1)
{
    max = num3;
}

Console.WriteLine("max = " + max);
