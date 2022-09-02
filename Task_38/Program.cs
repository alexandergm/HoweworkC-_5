double[] array = new double[10];
int max = 0;
int min = 0;
double diff = MinMax(InitialMas());
Console.WriteLine(diff);

double[] InitialMas()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(0, 10) + new Random().NextDouble()),2);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

double MinMax(double[] mas)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[max] < array[i]) max = i;
        else if(array[min] > array[i]) min = i; 
    }
    return Math.Round((array[max] - array[min]),2);
}
