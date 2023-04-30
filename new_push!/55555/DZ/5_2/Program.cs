// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int arrLength = 10; 
int arrMin = 1; 
int arrMax = 10; 

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray (arr);
Console.WriteLine($"There are {FindEven(arr)} even numbers");

int[] MakeArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindEven(int[] array)
{
    int count = 0;
    int len = array.Length;
    for (int i = 1; i < len; i+=2)
    {
        count+=array[i];
    }
    return count;
}