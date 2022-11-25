// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//  Первый способ через условие
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 & number1 > number3) Console.WriteLine($"Число {number1} самое большое");
else if(number2 > number3 ) Console.WriteLine($"Число {number2} самое большое");
else Console.WriteLine($"Число {number3} самое большое");

// Второй способ - с присвоением максимума и последующим сравнением
Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (numberTwo > max ) max = numberTwo ;
if (numberThree > max ) max = numberThree ;
Console.WriteLine(max);

// Есть и третий способ наиболее универсальный, но он решается через массивы, а мы их пока не проходили
