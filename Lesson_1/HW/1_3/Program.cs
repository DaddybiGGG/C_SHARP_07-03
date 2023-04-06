int num1 = 0;

Console.Write("Please enter number = ");
num1 = int.Parse(Console.ReadLine()!);

if ((num1 % 2) == 0)
{
    Console.WriteLine("yes!");
}
else
{
    Console.WriteLine("no!");
}
