// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите коэффициент b1: ");
double coefB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1: ");
double coefK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2: ");
double coefB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2: ");
double coefK2 = Convert.ToDouble(Console.ReadLine());
FindPointOfIntersection(coefK1, coefK2, coefB1, coefB2);

void FindPointOfIntersection(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают, система уравнений имеет бесконечное множество решений");
    else if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        double roundX = Math.Round(x, 2);
        double roundY = Math.Round(y, 2);
        Console.WriteLine($"Координаты точки пересечения прямых ({roundX}; {roundY})");
    }
}

