/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

Console.WriteLine("Задайте длину массива:");
int num = int.Parse(Console.ReadLine())!;

int[] newArray = CreatArray(num);
int SummPos = SummPositiveElement(newArray);
PrintResilt(newArray, SummPos);

int[] CreatArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        //Console.Write($"{arr[i]} ");
    }
    return arr;
}

int SummPositiveElement(int[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] % 2 == 0) { count++; }
    }
    return count;
}


void PrintResilt(int[] arr, int result)
{

    for (int i = 0; i <= arr.Length; i++)
    {
        if (i == 0) { Console.Write($"[{arr[i]}, "); };
        if (i > 0 && i < arr.Length - 1) { Console.Write($"{arr[i]}, "); };
        if (i == arr.Length - 1) { Console.Write($"{arr[i]}]"); };
    }
    Console.Write(" -> ");
    Console.Write(result);
    
}