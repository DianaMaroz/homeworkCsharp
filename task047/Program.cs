//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[] userData = ReadUserDataForMatrix();
double[,] doubleMatrix = CreateMatrixRndDouble(userData[0], userData[1],userData[2], userData[3]);
PrintMatrixDouble(doubleMatrix);

int[] ReadUserDataForMatrix()
{
    int[] data = new int[4];
    Console.WriteLine("Укажите количество строк: ");
    data[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите количество столбцов: ");
    data[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите минимальное значение для матрицы: ");
    data[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите максимальное значение для матрицы: ");
    data[3] = Convert.ToInt32(Console.ReadLine());
    return data;
}

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = Math.Round (rnd.NextDouble() * (max - min) + min, 2);
        }
    }
    return matrix;
}

void PrintMatrixDouble (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5}");
        }
         Console.WriteLine("|");
    }
}