// Задача 2: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

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

void Answer(int[] arr, int number)
{
    string number_1 = "Нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) { number_1 = "Да"; break; }
    }
     Console.WriteLine($"{number}, {number_1} ");
}

int[] arr_1 = NewArray(10);
Print(arr_1);
Answer(arr_1, 4);