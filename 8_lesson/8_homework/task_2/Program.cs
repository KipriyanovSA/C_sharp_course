// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void SumRowArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int min = 0;

    for (int i = 0; i < row_size; i++)
    {
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
        Console.Write($"{num,4} ");
        if (amount > num)
        {
            amount = num;
            min = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов - {min + 1}");
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column);
Print(arr_1);
Console.WriteLine();
SumRowArray(arr_1);