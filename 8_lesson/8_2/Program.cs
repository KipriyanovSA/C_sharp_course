// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

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

string ReplaceRows(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row != column) return "Невозможно";
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < i; j++)
        {
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }
    }
    return "Новый массив";
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column);
Print(arr_1);
Console.WriteLine();
Console.WriteLine(ReplaceRows(arr_1));
Print(arr_1);