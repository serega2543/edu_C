// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];

void MassFull(int[] collection){
    int len = collection.Length;
    int count = 0;
    while (count < len){
        collection[count] = new Random().Next(0, 2);
        count++;
    }
}

//Console.WriteLine(MassFull(array));
void WriteArray(int[] arr){
    for(int i=0; i<arr.Length;i++){
        Console.Write($"{arr[i]} ");
    }
}

MassFull(array);
WriteArray(array);