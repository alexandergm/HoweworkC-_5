int[] arr = new int[10];
int sum = 0;
Console.WriteLine(OddSum(InitialMas()));

int[] InitialMas()
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return arr;
}
int OddSum(int[] mas)
{
    for(int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}