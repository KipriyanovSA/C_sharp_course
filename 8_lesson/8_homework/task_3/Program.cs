// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] MultiArray(int[,] first_arr, int[,] second_arr)
{
    int row_size = first_arr.GetLength(0);
    int column_size = first_arr.GetLength(1);
    int[,] multi_arr = new int[row_size, column_size];

    if (row_size != second_arr.GetLength(0) || column_size != second_arr.GetLength(1)) Console.WriteLine("Не равнозначные массивы");
    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            multi_arr[i, j] = first_arr[i, j] * second_arr[i, j];
    return multi_arr;
}

Console.Write("Введите количество строк для первого массива: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов для первого массива: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк для второго массива: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов для второго массива: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row_1, column_1);
Print(arr_1);
Console.WriteLine();
int[,] arr_2 = FillArray(row_2, column_2);
Print(arr_2);
Console.WriteLine();
int[,] new_arr = MultiArray(arr_1, arr_2);
Print(new_arr);