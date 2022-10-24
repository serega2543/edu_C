/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите множестово числе через пробел: ");
string row = Console.ReadLine();

int[] newArray = StrToArray(row);
int positivCount = CountPositiveNumber(newArray);
PrintResilt(newArray, positivCount);


int[] StrToArray(string row)
{
    int[] arr = Array.ConvertAll(row.Split(), int.Parse);
    return arr;
}

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
 
void PrintResilt(int[] arr, int result)
{

    for (int i = 0; i <= arr.Length; i++)
    {
        if (i == 0) { Console.Write($"{arr[i]}, "); };
        if (i > 0 && i < arr.Length - 1) { Console.Write($"{arr[i]}, "); };
        if (i == arr.Length - 1) { Console.Write($"{arr[i]}"); };
    }
    Console.Write(" -> ");
    Console.Write(result);

}