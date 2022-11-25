// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateDoubleArrayRndInt (int size, int min, int max)
{
    double[] array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round (rnd.NextDouble() * (max - min) + min, 2);
    }
    return array;
}

void PrintDoubleArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMaxInArray (double[] array)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > result) result = array[i];
    }
    return result;
}

double FindMinInArray (double[] array)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] < result) result = array[i];
    }
    return result;
}

double TakeMinOutOfMax (double[] array)
{
    double max = FindMaxInArray(array);
    double min = FindMinInArray(array);
    double result = Math.Round(max - min, 2);
    return result;
}

double[] arr = CreateDoubleArrayRndInt(10, 1, 10);
PrintDoubleArray(arr);
double takeMinOutOfMax = TakeMinOutOfMax(arr);
Console.WriteLine(takeMinOutOfMax);