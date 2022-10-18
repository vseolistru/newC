//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

		
Random rnd = new Random();		
double k1 = Math.Round( rnd.NextDouble() * 10,1);
double b1 = Math.Round(rnd.NextDouble() * 10,1);
double b2 = Math.Round(rnd.NextDouble() * 10,1);
double k2 = Math.Round(rnd.NextDouble() * 10,1);
Console.WriteLine($" k1 - {k1}, b1 - {b1}, k2 - {k2}, b2 - {b2}");
double resX = (b2 - b1) / (k1 - k2);
double resY  = k1 * resX + b1;
Console.Write($"({Math.Round(resX,2)}, {Math.Round(resY,2)})");
