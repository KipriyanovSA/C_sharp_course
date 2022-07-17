//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет.

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
            arr[i, j] = new Random().Next(1, 11);
        }
    }
    return arr;
}

void FindNum(int[,] array, int row1, int column1)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row1 > array.GetLength(0) || column1 > array.GetLength(1))
            Console.WriteLine("Такого элемента нет");
                if (array[i, j] == array[row1 - 1, column1 - 1])
                {
                    Console.WriteLine(array[i, j]);
                    return;
                }
        }
    }
}

int[,] arr_1 = FillArray(3, 4);
Print(arr_1);
Console.WriteLine("Введите строку: ");
int row1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int column1 = int.Parse(Console.ReadLine());
Console.WriteLine();
FindNum(arr_1, row1, column1);