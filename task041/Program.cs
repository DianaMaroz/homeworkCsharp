// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//  Первый вариант с просьбой пользователю указать количество чисел
Console.WriteLine("Введите количество чисел: ");
int digitNumber = Convert.ToInt32(Console.ReadLine());
int howManyDigBiggerThen = HowManyDigBiggerThen (digitNumber, 0);
if (howManyDigBiggerThen == 0) Console.WriteLine("Нет чисел удовлетворяющих условию");
else Console.WriteLine($"Количество чисел, удовлетворяющих условию, равно {howManyDigBiggerThen}");
int HowManyDigBiggerThen (int size, int number)
{
    int answer = default;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > number) answer++;
    }
    return answer;
}

//  Второй вариант через создание массива из строки
Console.WriteLine("Введите числа через пробел: ");
string inputString = Console.ReadLine();
var ints = inputString.Split(' ').Select(Int32.Parse).ToArray();  
int howManyBiggerDigInArray = HowManyBiggerDigInArray(ints, 0);
if (howManyBiggerDigInArray == 0) Console.WriteLine("Нет чисел удовлетворяющих условию");
else Console.WriteLine($"Количество чисел, удовлетворяющих условию, равно {howManyBiggerDigInArray}");

int HowManyBiggerDigInArray (int[] array, int number)
{
    int answer = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > number) answer++;
    }
    return answer;
}
