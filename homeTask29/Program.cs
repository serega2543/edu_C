/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int[] array = new int[8];

MassFull(array);
WriteArray(array);

void MassFull(int[] collection)
{
    int len = collection.Length;
    int count = 0;
    while (count < len)
    {
        collection[count] = new Random().Next(0, 99);
        count++;
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i >= 0 && i < arr.Length - 2) { Console.Write($"{arr[i]}, "); };
        if (i == arr.Length - 1) { Console.Write($"{arr[i]}"); };
    }

    Console.Write(" -> ");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) { Console.Write($"[{arr[i]}, "); };
        if (i > 0 && i < arr.Length - 2) { Console.Write($"{arr[i]}, "); };
        if (i == arr.Length - 1) { Console.Write($"{arr[i]}]"); };
    }
}

