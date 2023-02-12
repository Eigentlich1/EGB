// Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void NumberCounter (int number)
{
    if (number == 0) 
    return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
