// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();


int minValue = 0;
int maxValue = 10;

int[,] array = GetArray(minValue, maxValue);
PrinTtwoDimensionalArray(array);



int[,] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < rows * columns; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < columns - 1);
        for (k = 0; k < columns - 1; k++) array[i++, j] = value++;
        for (k = 0; k < columns - 1; k++) array[i, j--] = value++;
        for (k = 0; k < columns - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        columns = columns < 2 ? 0 : columns - 2;
    }
    return array;
}

void PrinTtwoDimensionalArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10)
            {
                Console.Write($"0{inArray[i, j]} ");
            }
            else
            {
                Console.Write($"{inArray[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

