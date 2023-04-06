Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int i = 2;

if (n > 1)
{
    while (i <= n)
    {
        Console.Write(i + " ");
        i = i + 2;
        
    }
}