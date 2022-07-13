// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях

int[] NewArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SumOdd(int[] arr)
{
    int odd = 0;
    int length = arr.Length;
    
    for (int i = 1; i < length; i += 2)
    {
        odd += arr[i];
    }
    Console.WriteLine($"Сумма нечетных: {odd}");
}

int[] arr_1 = NewArray(5);
Print(arr_1);
SumOdd(arr_1);