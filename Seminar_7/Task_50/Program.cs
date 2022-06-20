// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введите количество строк массива: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colNumber = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[rowNumber, colNumber];
Random FillArray = new Random();
int[] sum = new int[colNumber];


for (int i = 0; i < rowNumber; i++)
{
    for (int j = 0; j < colNumber; j++)
    {
        Array[i, j] = FillArray.Next(0, 10);

        Console.Write(Array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < colNumber; i++)
{
    for (int j = 0; j < rowNumber; j++)
    {
       sum[i] += Array[j, i];
    }
}

for (int i = 0; i < colNumber; i++)
{
    Console.Write((sum[i] / rowNumber) + "; ");
}
Console.WriteLine();