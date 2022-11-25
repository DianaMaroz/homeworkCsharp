// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
PrintMatrixElementByIndex(array2D);

void PrintMatrixElementByIndex(int[,] matrix)
{
    Console.WriteLine("Укажите индекс строки: ");
    int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;
    if (rowNumber >= matrix.GetLength(0) || rowNumber < 0)
    {
         Console.WriteLine("Такого числа в массиве нет, неверно указана строка");
    }
    else
    {
        Console.WriteLine("Укажите индекс столбца: ");
        int columnNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        if (columnNumber >= matrix.GetLength(1) || columnNumber < 0)
        {
            Console.WriteLine("Такого числа в массиве нет");
        }
        else Console.WriteLine(matrix[rowNumber, columnNumber]);
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("   |");
    }
}