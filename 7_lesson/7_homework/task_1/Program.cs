//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  m = 3, n = 4
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

void PrintArray(double[,] arr)
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

double[,] FillArray(int row, int column)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
            double value = arr[i, j];
            arr[i, j] = (Math.Round(value, 1));
        }
    }
    return arr;
}

double[,] arr_1 = FillArray(3, 4);
PrintArray(arr_1);
