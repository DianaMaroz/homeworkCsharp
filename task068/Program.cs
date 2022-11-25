// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(3, 13) = 65533 у меня еще с этим справился, а 3, 14 stack overflow

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0) Console.WriteLine("Ошибка ввода: числа должны быть неотрицательными");
else
{
    int resultAckermann = AckermannFunction(numberM, numberN);
    Console.WriteLine($"A({numberM}, {numberN}) = {resultAckermann}");
}


int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
}