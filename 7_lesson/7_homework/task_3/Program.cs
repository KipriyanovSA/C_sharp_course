//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            arr[i, j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void MiddleOfColumns(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double result;

    for (int i = 0; i < column; i++)
    {
        result = 0;
        for (int j = 0; j < row; j++) result += arr[j, i];
        Console.Write($"{Math.Round(result / row, 2)}; ");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column);
Print(arr_1);
Console.WriteLine();
MiddleOfColumns(arr_1);