// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int lenghtArray = ReadInt("Введите длинну массива ");

int[] randomArray = new int[lenghtArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
int ReadInt(string m)
{
    Console.Write(m);
    return Convert.ToInt32(Console.ReadLine());
}