// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyMass(int[] arr)
{
    int[] new_arr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}

int[] arr_1 = NewArray(8);
Print(arr_1);
Console.WriteLine();
int[] arr_2_new = CopyMass(arr_1);
Print(arr_2_new);