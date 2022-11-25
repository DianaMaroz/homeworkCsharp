// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigit(int num)
{
    num = Math.Abs(num);
    int result = default;
    while (num > 0)
    {
        int lastDigit = num % 10;
        result = result + lastDigit;
        num = num / 10;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumDigit}");