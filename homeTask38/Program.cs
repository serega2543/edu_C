/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

Console.WriteLine("Задайте длину массива:");
int num = int.Parse(Console.ReadLine())!;

double[] newArray = CreatArray(num);
double SummPos = SummPositiveElement(newArray);
PrintResilt(newArray, SummPos);




double[] CreatArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble((new Random().Next(100, 1000))/10.0);
        //Console.Write($"{arr[i]} ");
    }
    return arr;
}

double SummPositiveElement(double[] arr2)
{
    double dif = arr2.Max() - arr2.Min();
    return dif;
}

void PrintResilt(double[] arr, double result)
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