Console.Clear();
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 < 10000 || number1 > 99999) 
{
        Console.WriteLine("Вы ошиблись! \nВведите пятизначное число : ");
        number1 = Convert.ToInt32(Console.ReadLine());
}
int n1 = (number1 / 10000 ) % 10;
int n2 = (number1 / 1000) % 10;
int n4 = (number1 / 10) % 10; 
int n5 = number1 % 10;
if (n1 == n5 && n2 == n4) Console.WriteLine($"Число {number1} палиндром");
else
    Console.WriteLine($"Число {number1} НЕ палиндром!");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Write("Введите X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());
double rast = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine($"Расстояние межу точками = {rast} ");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x <= number1; x++)
{
    Console.Write($"{Math.Pow(x, 3)} ");
}
*/


// dop zadanie

void PrintArray(int[] col) // Функция печати элементов массива
{
    int count = col.Length;
    int position = 0;
    while( position < count)
    {
        Console.Write($" {col[position]} ,");
        position++;
    }
}

Console.WriteLine("Введите число грядок N: ");
    int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
while(count < n )
{
    Console.WriteLine("Введите данные массива: ");
    array[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}
Console.Clear();
PrintArray(array);
Console.WriteLine();

int count2 = 1;
int max = array[1] + array[n - 1] + array[0];
int x = 0;
while(count2 < n-1 )
{
    x = array[count2 - 1] + array[count2] + array[count2 + 1];
    if(x > max ) max = x;
    count2++;
}

int max2 = array[0] + array[n - 2] + array [n - 1];
if( max2 > max ) max = max2;

Console.Write($"максимальное число ягод {max} ");