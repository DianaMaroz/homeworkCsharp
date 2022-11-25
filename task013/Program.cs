// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// функция по нахождению третьего числа через цикл
int ShowThirdDigit(int arg)
{
    while (arg > 999) 
    {
    arg = arg / 10;
    }
    return arg % 10;
}
// функция для определения есть ли третья цифра
bool IsThirdDigit (int num)
{ 
    return num > 99;
}
if (IsThirdDigit(number))  Console.WriteLine($"Третья цифра числа {number} -> {ShowThirdDigit(number)}");
else Console.WriteLine("Третьей цифры нет");
