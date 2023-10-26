﻿//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
class Program
{
    static int CalculateSum(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = CalculateSum(m, n);
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}");
    }
}