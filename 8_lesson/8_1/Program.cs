﻿// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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

int[,] MassNums(int row, int column, int from, int to)
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

void ReplaceRows(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < columns; i++)
    {
        (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
    }
}

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);

ReplaceRows(arr_1);
Print(arr_1);