//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = ReadInt("Введите число ");

int lenght = NumberLen(number);
Summ(number, lenght);
int NumberLen(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}
void Summ(int num, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
}
int ReadInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}