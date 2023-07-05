// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
//Console.WriteLine("Введите размер массива size: ");
//int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение для диапазона: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для диапазона: ");
int max = int.Parse(Console.ReadLine());
int [] array = FillArray(8, min, max );
int [] FillArray(int size, int min, int max)
{
    int [] result = new int [size];
    for (int i = 0; i < 8; i ++)
    {
        result [i] = new Random().Next(min, max);
    }
    return (result);
}
Console.WriteLine($"[{String.Join(", ", array)}] ");
