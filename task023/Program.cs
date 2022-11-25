// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void MakeNumCubeTable (int num)
{
    int count = 1;
    while (count <= num) 
    {
        Console.WriteLine($"{count, 3} | {count * count * count, 7} |");
        count++;
    }
}
if (number > 0) MakeNumCubeTable(number);
else Console.WriteLine ("Введено некорректное значение");
