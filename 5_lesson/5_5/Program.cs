﻿// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

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

int[] SecondArr(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_arr[i] = arr[i] * arr[size - i - 1];

    if (new_arr[flex_size - 1] == 0)
        new_arr[flex_size - 1] = arr[flex_size - 1];
    return new_arr;
}

int[] arr_1 = NewArray(6);
Print(arr_1);
int[] arr_1_new = SecondArr(arr_1);
Print(arr_1_new);