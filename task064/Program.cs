// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbersFromNToOne(number);
Console.WriteLine();
int[] arrayFromNToOne = new int[number];
FillArrayFromNToOne(1, arrayFromNToOne);
PrintArray(arrayFromNToOne);


void NaturalNumbersFromNToOne (int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbersFromNToOne (num - 1);
}
// Заполненение массива от  N до 1
void FillArrayFromNToOne (int num, int[] arr)
{
    arr[arr.Length - num] = num;
    if (num == arr.Length) return;
    FillArrayFromNToOne (num + 1, arr);   
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