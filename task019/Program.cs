// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение через сравнение 1 и 5, 2 и 4 чисел
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome (int num)
{
    int dig1 = (num % 100000) / 10000;
    int dig2 = (num % 10000) / 1000;
    int dig4 = (num % 100) / 10;
    int dig5 = num % 10;
    return dig1 == dig5 && dig2 == dig4;
}
if (number > 9999 && number < 100000) 
{
    if (IsPalindrome(number)) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введено некорректное значение");


// Решение через разворот

int NumReverse (int numI)
{
    int numR = 0;
    while (numI > 0)
    {
        int lastDig = numI % 10;
        int currentLength = Convert.ToString(numI).Length;
        numR = numR + lastDig * Convert.ToInt32(Math.Pow(10, (currentLength - 1)));
        numI = numI / 10;
    }
    return numR;
}
Console.WriteLine(NumReverse(number));

bool PalindromeReverse (int num)
{
    return num == NumReverse(num);
}
if (number > 9999 && number < 100000) 
{
    if (PalindromeReverse(number)) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введено некорректное значение");