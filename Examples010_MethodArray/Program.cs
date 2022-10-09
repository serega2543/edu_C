int[] array = { 1, 2, 3, 4, 5, 6, 78, 9 };

int n = array.Length; //определяем длину массива
int find = 6;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}