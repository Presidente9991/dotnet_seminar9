/* 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма чисел от {m} до {n} -> ");
Console.WriteLine(GetSum(m, n));

int GetSum(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    return end + GetSum(start, end - 1);
}