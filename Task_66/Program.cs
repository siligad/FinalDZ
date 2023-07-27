﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NumbersSum (int start, int end)
{
    int sum = start;
    if (start==end)
        return sum;
    else
    {
        sum=sum+NumbersSum(start+1,end);
        return sum;
    }
}

int M,N, sum;
Console.Write("Введите число начала диапазона:");
M=int.Parse(Console.ReadLine());
Console.Write("Введите число конца диапазона:");
N=int.Parse(Console.ReadLine());
sum=NumbersSum(M,N);
Console.Write($"Сумма равна {sum}");