// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int arg)
{
    return (arg % 100) / 10;
}
string numberToString = Convert.ToString(number);
if (numberToString.Length != 3) Console.WriteLine("Ошибка ввода");

else
{
    int result = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} -> {result}");
}
 // Но на трехзначность можно было проверить и через булевую функцию
bool IsTreeDigit (int num)
{
    return num > 99 && num < 1000;
}
Console.WriteLine("Введите трехзначное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (IsTreeDigit(numberA)) Console.WriteLine($"Вторая цифра числа {numberA} -> {ShowSecondDigit(numberA)}");
else Console.WriteLine("Ошибка ввода");