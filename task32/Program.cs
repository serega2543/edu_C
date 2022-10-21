// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] ourArray = GetArray(12, -9, 9);
SwitchArray(ourArray);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    //Console.Write("Старый массив:");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void SwitchArray(int[] arr)
{
    Console.WriteLine();
    //Console.Write("Новый массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write($"{arr[i]} ");
    }
}