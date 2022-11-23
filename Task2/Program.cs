using System;

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.Write("max = ");
Console.Write(max);



