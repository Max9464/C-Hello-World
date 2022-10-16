/*
int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}

int a = 13;
int b = 1118;
int c = 350;
int d = 55;
int f = 100;
int g = 4;
int k = 90;
int l = 3000;
int w = 3400;

int max1 = Max((a, b, c), Max(d, f, g), Max(k, l, w));

Console.Write(max);
*/


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}//             0  1  2  3   4   5   6   7   8     индекс масива начинается с нуля                      
int[] array = { 1, 2, 3, 56, 85, 95, 56, 21, 35 };
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);



