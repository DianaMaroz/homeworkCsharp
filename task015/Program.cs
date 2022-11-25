// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
bool IsDayOff (int num)
{
    return num > 5;
}
bool IsNumberCorrect (int arg)
{
    return arg > 0 && arg < 8;
}

if (IsNumberCorrect(number))
{
    if (IsDayOff(number)) Console.WriteLine ("Ура! Выходной!");
    else 
    {
        if (6 - number == 1) Console.WriteLine ($"Нет, придется поработать еще {6 - number} день");
        else if (6 - number == 5) Console.WriteLine ($"Нет, придется поработать еще {6 - number} дней");
        else Console.WriteLine ($"Нет, придется поработать еще {6 - number} дня");
    }
}
else Console.WriteLine ("Ошибка ввода");