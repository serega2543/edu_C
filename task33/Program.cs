// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();

Console.WriteLine("ВВедите число:");
int number = int.Parse(Console.ReadLine());
int[] array = GetArray(12, -9, 9);

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

void CheckNumber(int num, int [] arr)
{
    string check = "Нет";
    foreach(int el in arr)
    {
        if (el == num)
        {
            check = "Да";
            break;
        }
    }
    Console.WriteLine(check);
}