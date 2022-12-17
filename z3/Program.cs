/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Размер массива, минимальное значение и максимальное значение вводим через консоль
Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
[3 7 22 2 78] -> 76
*/
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите min: ");
int minimum = int.Parse(Console.ReadLine()!);
Console.Write("Введите max: ");
int maxsimum = int.Parse(Console.ReadLine()!);

double[] array = GenArray(size, minimum, maxsimum);

PrintArray(array);
Console.WriteLine("Разница между min и max = " + (Maxi(array) - Mini(array)));

double Maxi(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    Console.WriteLine("Максимальное число = " + max);
    return max;
}

double Mini(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine("Минимальное число = " + min);
    return min;
}

double[] GenArray(int n, double min, double max)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round (new Random().NextDouble() * (max - min) + min, 2);
    }
    return array;
}

void PrintArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}