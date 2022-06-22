//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] GetRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(0, 15);
        }
    }
    return result;
}

void SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void Print2DArray(int[,] array)
{
    Console.Write($"\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Исходный массив: ");
int[,] Array = GetRandomArray(5, 5);
Print2DArray(Array);
Console.WriteLine("Отсортированный массив: ");
SortedArray(Array);
Print2DArray(Array);
