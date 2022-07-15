// Задача 3: Напишите программу, которая будет создавать копию 
// заданного двумерного массива с помощью поэлементного копирования.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] NewArray(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int[,] CopyArr(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }
    }
    return new_arr;
}

int[,] arr_1 = NewArray(3, 4);
PrintArray(arr_1);
Console.WriteLine();
int[,] arr_1_new = CopyArr(arr_1);
PrintArray(arr_1_new);