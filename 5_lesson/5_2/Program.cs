// Задача 1: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.

int[] NewArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
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

void ChangeNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] arr_1 = NewArray(10);
Print(arr_1);
ChangeNum(arr_1);
Print(arr_1);