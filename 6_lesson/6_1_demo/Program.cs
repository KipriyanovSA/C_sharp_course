// Задача 1: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

int[] NewArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 500);
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

int[] ReversMas(int[] arr)
{
    int size = arr.Length - 1;
    for (int i = 0; i < size / 2 + 1; i++)
        (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
    return arr;
}

int[] arr_1 = NewArray(7);
Print(arr_1);
ReversMas(arr_1);
Print(arr_1);