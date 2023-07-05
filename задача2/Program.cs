// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число n :");
int n = int.Parse(Console.ReadLine());
int GetSum (int n)
{
    int sum = 0;
    while ( n >0 )
    {
        sum = sum + n%10;
        n = n/10;
    }
    return sum;
}
Console.WriteLine($" {GetSum (n)}");