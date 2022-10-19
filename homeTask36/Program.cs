/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

Console.WriteLine("Задайте длину массива:");
int num = int.Parse(Console.ReadLine())!;

int[] newArray = CreatArray(num);
int SummEl = SummOddElement(newArray);
PrintResilt(newArray, SummEl);

int[] CreatArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 10);
        //Console.Write($"{arr[i]} ");
    }
    return arr;
}

int SummOddElement(int[] arr2)
{
    int summ = 0;
    for (int i = 1; i < arr2.Length; i= i+2)
    {
        summ = summ + arr2[i];
    }
    return summ;
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