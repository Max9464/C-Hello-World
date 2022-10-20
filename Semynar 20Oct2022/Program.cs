// Math.Pow = (a,b) = ab-(b квадрат числа a)
// Math.Sqrt(a)= a в степени
// Math.Round(a,b)

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void ShowRange(int quart)
{
    if (quart == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if (quart == 2)
        Console.WriteLine("x < 0 and y > 0");
    else if (quart == 3)
        Console.WriteLine("x < 0 and y < 0");
    else if (quart == 4)
        Console.WriteLine("x > 0 and y < 0");
    else
        Console.WriteLine("Wrong number!");
}

Console.WriteLine("Input a number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int findnumber(int x, int y)
{
    int quart = 0;
    if (x > 0 && y > 0)
    {
        quart == 1;
    }
        if (x < 0 && y > 0)
    {
        quart == 2;
    }
        if (x < 0 && y < 0)
    {
        quart == 3;
    }
        if (x > 0 && y < 0)
        {
            quart == 4;
        }
        return quart;
}
Console.WriteLine("Input x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y ");
int y = Convert.ToInt32(Console.ReadLine());
int quart = findnumber(x, y);
Console.WriteLine($"Show {quart}");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindNumber(double x1, double y1, double x2, double y2)
{
    double lenght = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow (y2 - y1, 2));
    return lenght;
}
Console.WriteLine("input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x1");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x1");
int y2 = Convert.ToInt32(Console.ReadLine());
double lenght = FindNumber(x1, y1, x2, y2);
Console.WriteLine($"Show {Math.Round(lenght, 3)}");
*/
// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void square(int n)
{
    int current = 1;

    while(current <= n)
    {
        Console.Write(current * current);
        current++;
    }
}
Console.WriteLine("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
square(n);
*/