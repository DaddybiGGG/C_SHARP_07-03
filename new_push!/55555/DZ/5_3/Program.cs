// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int arrLength = 5;
int arrMin = 1;
int arrMax = 10;

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray(arr);
Console.WriteLine($"There are {FindEven(arr)} even numbers");

int[] MakeArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
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
    int min = array[0];
    int max = 0;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return max - min;

}