// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] firstMatrix = CreateMatrixRndInt(3, 3, 1, 5);
int[,] secondMatrix = CreateMatrixRndInt(3, 2, 1, 5);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
if (CheckMatrixForMultiplication(firstMatrix, secondMatrix))
{
    int [,] multiplicatedMatrix = MultiplicateMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(multiplicatedMatrix);
}
else Console.WriteLine("Данные матрицы нельзя перемножить");

int[,] MultiplicateMatrix(int[,] arrA, int[,] arrB)
{
    int[,] resultMatrix = new int[arrA.GetLength(0), arrB.GetLength(1)];
    int numberMatrix = arrA.GetLength(1);
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < numberMatrix; k++)
            {  
                resultMatrix[i,j] +=  arrA[i,k] *arrB[k,j];
            }
          
        }
    }
    return resultMatrix;
}

bool CheckMatrixForMultiplication(int[,] arrA, int[,] arrB)
{
    return arrA.GetLength(1) == arrB.GetLength(0);
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