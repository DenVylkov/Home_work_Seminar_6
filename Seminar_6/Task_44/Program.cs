//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write($"Введите первое N количество чисел Фибоначчи: ");
int Ncount = Convert.ToInt32(Console.ReadLine());
int FirstNumber = 0;
int SecondNumber = 1;
int result;
Console.Write($"Если N = {Ncount} -> {FirstNumber} {SecondNumber} ");
for (int i = 0; i < Ncount - 2; i++)
{
    result = FirstNumber + SecondNumber;
    FirstNumber = SecondNumber;
    SecondNumber = result;
    Console.Write(result + " ");
}

Console.WriteLine();