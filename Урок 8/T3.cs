//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matrix = new int[3, 3];
int[,] array = new int[3, 3];
int[,] secondArray = new int[3, 3];;
int[,] resultArray = new int[3, 3];;

FillArrayRandom(array);
PrintArray2D(array);
Console.WriteLine();
FillArrayRandom(secondArray);
PrintArray2D(secondArray);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
PrintArray2D(resultArray);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
