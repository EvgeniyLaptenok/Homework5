/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Размер массива вводим через консоль
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
//Console.Write("Введите min: ");
//int minimum = int.Parse(Console.ReadLine()!);
//Console.Write("Введите max: ");
//int maxsimum = int.Parse(Console.ReadLine()!);

int[] array = GenArray(size);

PrintArray(array);
Even(array);

int Even(int[] arr)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    Console.WriteLine("Кол-во четных элементов в массиве = " + evenNum);
    return evenNum;
}

int[] GenArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}