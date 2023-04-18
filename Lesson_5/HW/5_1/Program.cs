

int[] MakeArray(int length, int min, int max)
{
int[] arr = new int[length];
for(int i = 0; i < length; i++)
{
arr[i] = new Random().Next(min, max + 1);
}
return arr;
}

Console.WriteLine(MakeArray(arr));