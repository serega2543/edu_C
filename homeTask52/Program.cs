// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrinTtwoDimensionalArray(array);
Console.WriteLine();
double[] arithArr = ArithmeticMean(array);
PrintResult(arithArr); 

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

double[] ArithmeticMean(int[,] inArray)
{
    double[] resultArr = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double res = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            res += inArray[j, i];
        }
        res = res/(inArray.GetLength(0));
        resultArr[i] = res;
    }
    return resultArr;
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

void PrintResult(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i <= arr.Length; i++)
    {
        if (i >= 0 && i < arr.Length - 1) { Console.Write($"{arr[i]}; "); };
        if (i == arr.Length - 1) { Console.Write($"{arr[i]}."); };
    }
}