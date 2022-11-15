// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int minValue = 0;
int maxValue = 10;

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Начальный массив:");
PrinTtwoDimensionalArray(array);
SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrinTtwoDimensionalArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrinTtwoDimensionalArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] inArray)
{
    int[] newArr = new int[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            newArr[j] = inArray[i, j];
        BubbleSort(newArr);
        //PrintArray(newArr);
        for (int j = 0; j < inArray.GetLength(1); j++)
            inArray[i, j] = newArr[j];    
    }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i <= arr.Length; i++)
    {
        if (i == 0) { Console.Write($"{arr[i]} "); };
        if (i > 0 && i < arr.Length - 1) { Console.Write($"{arr[i]} "); };
        if (i == arr.Length - 1) { Console.Write(arr[i]);};
    }
    Console.WriteLine();
}