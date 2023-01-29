// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32 (Console.ReadLine());
GetExtentnt (num1, num2);

void GetExtentnt (int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    Console.WriteLine(result);
}