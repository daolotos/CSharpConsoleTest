﻿using System;

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i = i + 2)
{
    Console.Write(i);
    Console.Write("  ");
}

