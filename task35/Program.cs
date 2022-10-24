// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



Console.Clear();

int[] ourArray = GetArray(123, 0, 99);
CheckArray(ourArray);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    //Console.Write("Старый массив:");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        //Console.Write($"{res[i]} ");
    }
    return res;
}

void CheckArray(int[] arr)
{
    //Console.WriteLine();
    //Console.Write("Новый массив:");
    int i = 0;
    foreach (int el in arr)
    {
        if(el>=10 && el<=99)
        {
            i++;
        }
    }
    Console.WriteLine($"Число найденных элементов: {i}");
}