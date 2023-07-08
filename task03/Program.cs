﻿/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
Выполнить с помощью рекурсии.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

Console.Write("Введите целое неотрицательное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите целое неотрицательное число N: ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0) Console.WriteLine("Числа m и n должны быть неотрицательными! Попробуйте ещё раз!");
else
{
    Console.Write($"Значение функции Аккермана от аргументов {m} и {n} равно ");
    Console.WriteLine(GetAkkerman(m, n));
}

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    else
    {
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
}