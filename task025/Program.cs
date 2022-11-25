// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PutAinPowerB(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}
double PutAinPowerMinus(int numbA, int numbB)
{
    int absNumbB = Math.Abs(numbB);
    double divisor = Convert.ToDouble(PutAinPowerB(numbA, absNumbB));
    double result = 1 / divisor;
    return Math.Round(result, 5);
}
Console.WriteLine("Введите число для возведения в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую будет возводиться число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB >= 0)
{
    int putAinPowerB = PutAinPowerB(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени  {numberB} = {putAinPowerB}");
}
else
{
    double putAinPowerB = PutAinPowerMinus(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени  {numberB} = {putAinPowerB}");
}
