﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine() ?? string.Empty;
int len = number.Length;
if (len == 5)
    {
    if (number[0] == number[4] && number[1] == number[3])
    {
    Console.WriteLine("палиндром");
    }
    else
    {
    Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine("не пятизначное число");
}