// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число M:");
int numberN = Convert.ToInt32(Console.ReadLine());

void SummNumber (int numA, int numB, int summ)
{
    if (numA > numB) 
    {
        Console.WriteLine($"Сумма элементов в промежутке {summ}"); 
        return;
    }
    summ = summ + (numA++);
    SummNumber(numA, numB, summ);
}

SummNumber(numberM, numberN, 0);