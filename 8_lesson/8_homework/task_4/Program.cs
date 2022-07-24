// Задайтедвумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] MinElement(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

int[,] HideRowColumn(int[,] arr, int[] new_indexes)
{
    int n = 0;
    int s = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_array = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (new_indexes[0] != i && new_indexes[1] != j)
            {
                new_array[n, s] = arr[i, j];
                s += 1;
            }
        }
        s = 0;
        if (new_indexes[0] != i) n += 1;
    }
    return new_array;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column);
Print(arr_1);
Console.WriteLine();
int[] MinEl = MinElement(arr_1);
Console.WriteLine();
int[,] arr_2 = HideRowColumn(arr_1, MinEl);
Print(arr_2);