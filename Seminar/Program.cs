Console.Clear();

// Task 17
/*

Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0 || y == 0)
{
    Console.WriteLine("Вы ошиблись! Введите координаты заново!");
    Console.Write("Введите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");
*/

// Task 18
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
if ( x == 1) Console.Write($"Четверть{x} x(-& ; 0) y(0 ; +&)");
else if (x == 2) Console.Write($"Четверть{x} x(0 ; +&) y(0 ; +&)" );
else if (x == 3) Console.Write($"Четверть{x} x(-& ; 0) y(-& ; 0)" );
else if (x == 4) Console.Write($"Четверть{x} x(0 ; +&) y(-& ; 0)");
*/
/*
// Task 22
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x <= n; x++)
{
    Console.Write($"{Math.Pow(x, 2)} ");
}
*/

/*
// Task 21
 // Math.Round - оркугление
 // Math.Sqrt - квадрат
 // Math.Pow - степень ВСЕ В 
Console.Clear();
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
Console.WriteLine(l);
*/
