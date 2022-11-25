// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Первый способ без проверки на четность
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2) Console.WriteLine("Нет чисел удовлетворяющих условию");
else {
    Console.Write(2); // поскольку не умею выводить красиво через запятую, то пришлось немного изголиться
    int counter = 4;
    while (counter <= number) {
       Console.Write($", {counter}"); 
       counter += 2;
    }
}

// Второй способ с проверкой на четность
	Console.WriteLine("Введите число:");
	int num = Convert.ToInt32(Console.ReadLine());
	if (num < 2) Console.WriteLine("Нет чисел удовлетворяющих условию");
	else {
	    Console.Write(2); // поскольку не умею выводить красиво через запятую, то пришлось немного изголиться
	    int counter = 4;
	    while (counter <= num) {
            if (counter % 2 == 0) Console.Write($", {counter}"); 
	       counter ++;
	    }
	}

// Третий способ через цикл без проверки четности
 Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 2) Console.WriteLine("Нет чисел удовлетворяющих условию");
else {
    Console.Write(2); 
    for (int i = 4; i <= numA; i +=2) Console.Write($", {i}");
}