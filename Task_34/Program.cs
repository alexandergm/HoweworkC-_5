int[] arr = new int[10];
int sum = 0;
Console.WriteLine(Even(InitialMas()));

int[] InitialMas()
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return arr;
}

int Even(int[] mas)
{
    foreach(int count in arr)
    {
        if(count % 2 == 0) sum++; 
    }
    return sum;
}