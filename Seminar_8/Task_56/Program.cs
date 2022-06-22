//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

void Print2DArray(int[,] array)
{
    Console.Write($"\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("["+ i + "]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
         int Sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
        {
        Sum += array[i,j];
        }
        Console.WriteLine($"Сумма элементов строки = {Sum}");
    }
}

int[,] Array = GetRandomArray(4, 4);
Print2DArray(Array);

int MinSumLine = 0;
int SumLine = SumLineNumbers(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
  int temp = SumLineNumbers(Array, i);
  if (SumLine > temp)
  {
    SumLine = temp;
    MinSumLine = i;
  }
}

int SumLineNumbers(int[,] Array, int i)
{
  int SumLine = Array[i,0];
  for (int j = 1; j < Array.GetLength(1); j++)
  {
    SumLine += Array[i,j];
  }
  return SumLine;
}

Console.WriteLine();
Console.WriteLine($"Строка № {MinSumLine} обладает наименьшей суммой элементов ({SumLine}).");
Console.WriteLine();



