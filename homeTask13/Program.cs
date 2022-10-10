// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int numStr = num.ToString().Length;
//Console.WriteLine(numStr);

if (numStr > 2)
{
//    int firstNum = num / 100;
//    int secondNum = (num % 100) /10;
    double thirdNum = num % Convert.ToInt32(Math.Pow(10, numStr-2)) / Convert.ToInt32(Math.Pow(10, numStr-3));
    //int result = thirdNum / 10;
//    Console.WriteLine("Первая цифра: " + firstNum);    
//    Console.WriteLine("Вторая цифра: " + secondNum);  
//    Console.WriteLine(secondNum);  
//    Console.WriteLine("Третья цифра: " + thirdNum);  
    Console.WriteLine(thirdNum);  

}
else
{
    Console.WriteLine("третьей цифры нет");
}