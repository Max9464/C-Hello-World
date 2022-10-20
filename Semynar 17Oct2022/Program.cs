/*void - // метод который завершает работу и не возвращается к нему
int - метод который возвращается
Методы реализуют один функцианал, своя задача
*/

// Задача Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100, 1000); // переменная генерации случайных чисел

int result = CutNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");
*/

// Задача 1: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Задача 2: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
// Задача 3: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
int Maxnumber(int max)
{
    int a = max % 10;
    int b = max / 10 - a;
    if (a > b)
{
    max = a;
}
else
{
    max = b;
}
    return max;
}
int num = new Random().Next(10, 100);
int result = Maxnumber(num);

Console.WriteLine($"Max number of {num} is {result}");
*/

bool Square(int a, int b)
{
    if (a == b * b || b == a * a)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Ведите первую цифру ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите вторую цифру ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Square(true);
Console.WriteLine($"Number {result}");