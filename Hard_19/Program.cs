Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
long result = 0;
result = RevertNum(number);
Palynodrome();

long RevertNum(long count)
{
    while (count > 0) {
        result *= 10; 
        result += count % 10; 
        count /= 10; 
    }
    return result;
}
void Palynodrome()
{
    if (number == result)
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + number + " не является палиндромом");
    }
}