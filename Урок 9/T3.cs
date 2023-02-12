// Напишите программу вычисления функции Аккермана с помощью рекурсии.
Console.WriteLine("Введите первое число");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numN = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

Console.WriteLine(AckermannFunction(numM, numN));