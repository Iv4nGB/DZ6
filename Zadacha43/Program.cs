// Zadacha43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
// Значения b1, k1, b2 и k2 задаются пользователем.
double k1 = 1;
double b1 = 4;
double k2 = 5;
double b2 = -3;

double x = (b2-b1)/(k1-k2);
x = Math.Round(x, 2);
double y = k1 * x + b1;
y = Math.Round(y, 2);
Console.WriteLine($"Точка пересечения A ({x}, {y})");