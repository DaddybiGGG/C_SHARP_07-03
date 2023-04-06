int max = 0;
int min = 0;

Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine("max = " + max + " и " + "min = " + min);


