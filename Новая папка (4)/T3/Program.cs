// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число:");     
 int num = Convert.ToInt32(Console.ReadLine()); 
    if (num >= 1 && num <= 5) 
    { 
    Console.Write("Это будний"); 
    } 
    else if (num >= 6 && num <= 7) 
    { 
    Console.Write("Да, это выходной"); 
    } 
    else Console.Write("Нет соответствующего дня недели"); 