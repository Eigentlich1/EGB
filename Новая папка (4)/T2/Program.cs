// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number / 10);
    if (result < 10)
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
    {
          Console.WriteLine(number % 10);
    }