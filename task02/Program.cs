// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Первый способ - через простое ветвление с условием a > b

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) Console.WriteLine($"Число {numberA} больше {numberB}");
else Console.WriteLine($"Число {numberB} больше {numberA}");

// Второй способ - с присвоением максимума и последующим сравнением
Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (numberTwo > max ) max = numberTwo ;
Console.WriteLine(max);

// Есть и третий способ наиболее универсальный, но он решается через массивы, а мы их пока не проходили