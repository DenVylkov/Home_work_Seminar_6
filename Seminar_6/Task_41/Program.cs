//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую или пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
int Numbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел больше ноля -> {Numbers(array)}");