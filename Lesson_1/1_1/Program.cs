int num1 = 0;
int num2 = 0;

Console.Write("Please enter number 1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Please enter number 2 = ");
num2 = int.Parse(Console.ReadLine()!);

if ((num2 * num2) == num1)
{
    Console.WriteLine("yes!");
}
else
{
    Console.WriteLine("no!");
}
