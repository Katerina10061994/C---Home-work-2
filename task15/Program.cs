﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 5)
{
    Console.WriteLine($"будний день");
} 
else if (n >= 6 && n <= 7)
{
    Console.WriteLine($"выходной день");
}
else if (n >=8)
{
    Console.WriteLine($"это не день недели");
}
