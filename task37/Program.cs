// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine());

int[] ourArray = GetArray(num, 1, 10);
ExpArray(ourArray);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void ExpArray(int[] arr)
{
    int count = 0;
    if (arr.Length % 2 == 0)
    {
        count = arr.Length / 2;
    }
    else
    {
        count = arr.Length / 2 + 1;
    }
    Console.WriteLine($"\nДлина нового массива {count}");
    int[] newArr = new int[count];
    for (int i = 0; i < count; i++)
    {
        if (i == count)
        {
            newArr[i] = arr[i];
        }
        else
        {
            newArr[i] = arr[i] * (arr[i] - 1 - i);
        }
        Console.Write($"{newArr[i]} ");
    }
    // Console.Write($"{newArr[i]} ");
}