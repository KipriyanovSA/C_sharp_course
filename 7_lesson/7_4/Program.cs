// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.


void PrintArray(int[,] arr)
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

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void SquaresEvenPosOfArray(int[,] arr)
{
    int rowsNubmer = arr.GetLength(0);
    int columnNumber = arr.GetLength(1);

    for (int i = 0; i < rowsNubmer; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
                arr[i, j] *= arr[i, j];
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] arr_1 = FillArray(row, column, 1, 10);
PrintArray(arr_1);
SquaresEvenPosOfArray(arr_1);
PrintArray(arr_1);