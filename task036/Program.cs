// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOddPositionNumberInArray (int[] array)
{
    int result = default;
    for (int i = 1; i < array.Length; i += 2) // без проверки на нечетность индекса
    {
        result += array[i];
    }
    return result;
}

int SumOddPositionNumberInArrayWithOddCheck (int[] array)
{
    int result = default;
    for (int i = 0; i < array.Length; i++) // с проверкой на нечетность индекса
    {
        if (i % 2 == 1) result += array[i];
    }
    return result;
}

int[] arr = CreateArrayRndInt(10, -20, 20);
PrintArray(arr);
int sumOddPositionNumberInArray = SumOddPositionNumberInArray(arr);
Console.WriteLine(sumOddPositionNumberInArray);

int[] arr2 = CreateArrayRndInt(5, -10, 10);
PrintArray(arr2);
int withOddCheck = SumOddPositionNumberInArrayWithOddCheck(arr2);
Console.WriteLine(withOddCheck);