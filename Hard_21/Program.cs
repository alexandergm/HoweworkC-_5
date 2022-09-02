Console.WriteLine("Введите размер N-мерного пространства: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] firstDot = new int[N];
int[] secondDot = new int[N];

var a = firstDot;
Console.WriteLine(DistanceGet());

string DistanceGet()
{
    double distance = 0;
    for(int j = 0; j < 2; j++)
    {    
        for(int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент {j + 1}-й точки");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        a = secondDot;
    }
    for(int i = 0; i < a.Length; i++)
    {
        distance = distance + (Math.Pow((secondDot[i] - firstDot[i]),2));
    }
    distance = Math.Round(Math.Sqrt(distance),2);
    return $"Расстояние между 2мя точками в {N}-мерном пространстве = {distance}";    
}
