/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

static uint AckermannFunction(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermannFunction(n - 1, 1);
    else
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}
 
uint M,N;
Console.Write("Введите число начала диапазона:");
M=uint.Parse(Console.ReadLine());
Console.Write("Введите число конца диапазона:");
N=uint.Parse(Console.ReadLine());
Console.WriteLine($"Функия Аккермана A({M},{N})={AckermannFunction(M, N)}");