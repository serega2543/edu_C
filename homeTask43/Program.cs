/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
int b1 = InData("b1");
int k1 = InData("k1");
int b2 = InData("b2");
int k2 = InData("k2");

double[] interLineas = IntersectionLines(b1, b2, k1, k2);
double x = RoundingNum(interLineas[0], 3);
double y = RoundingNum(interLineas[1], 3);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");



double[] IntersectionLines(double b1, double b2, double k1, double k2)
{
    //y = k1 * x + b1
    //y = k2 * x + b2
    //k1 * x + b1 = k2 * x + b2
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    double[] arr = new double[2] { x, y };
    return arr;
}

double RoundingNum(double n, int bit)
{
    return Math.Round(n, bit);
}

int InData(string point)
{
    Console.WriteLine($"Введите {point}:");
    int res = int.Parse(Console.ReadLine());
    return res;
}