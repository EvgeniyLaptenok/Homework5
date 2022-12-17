/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Размер массива, минимальное значение и максимальное значение вводим через консоль
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите min: ");
int minimum = int.Parse(Console.ReadLine()!);
Console.Write("Введите max: ");
int maxsimum = int.Parse(Console.ReadLine()!);

int[] array = GenArray(size, minimum, maxsimum);

PrintArray(array);
UnevenSum(array);

int UnevenSum(int[] arr)
{
    int unevenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            unevenNum += array[i];
        }
    }
    Console.WriteLine("Сумма нечетных элементов = " + unevenNum);
    return unevenNum;
}

int[] GenArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
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