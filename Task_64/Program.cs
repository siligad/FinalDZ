/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void ShowNumbers( int end)
{
    if (end==1)
        Console.Write($"{end}  ");
    else
    {
        Console.Write($"{end}  ");
        ShowNumbers(end-1);
    }
}

int N;
Console.Write("Введите конечное число диапазона: ");
N = int.Parse(Console.ReadLine());
ShowNumbers(N);