/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());

int temp = num;
int reverse = 0;
while(num > 0)
{
    int dig = num % 10;
    reverse = reverse * 10 + dig;
    num = num / 10;
}

//Console.WriteLine(rev);
if(temp == reverse)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}