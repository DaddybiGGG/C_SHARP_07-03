// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number = GetUserNumber();
int degree = GetUserDegree();
Console.WriteLine($"{number} to the power of {degree} is {Calculation()}");

int GetUserNumber()
{
    int number = 0;
    while (number == 0)
    {
        Console.Write("Please enter number: ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

int GetUserDegree()
{
    int degree = 0;
    while (degree == 0)
    {
        Console.Write("Please enter degree: ");
        degree = int.Parse(Console.ReadLine()!);
    }
    return degree;
}

int Calculation()
{
    int calculation = 1;
    int i = 0;
    while (i < degree)
    {
        calculation *= number;
        i++;
    }
    return calculation;
}
