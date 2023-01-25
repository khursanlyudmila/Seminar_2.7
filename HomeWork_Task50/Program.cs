/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] InitArray(int str, int columns)
{
    int[,] result = new int[str, columns];
    Random rnd = new Random();

    for (int i = 0; i < str; i++)
        for (int j = 0; j < columns; j++)
        {
            {
                result[i, j] = new Random().Next(-100, 100);
            }
        }
    return result;
}

void PrintArray(int[,] array)
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

int GetNumber(string message)
{
    Console.WriteLine(message);
    int str = Convert.ToInt32(Console.ReadLine());
    return str;
}
int str = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int[,] matrix = InitArray(str, columns);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int findNumber = GetNumber("Введите искомое число");

bool numberFound = false;

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (matrix[i, j] == findNumber)
        {
            Console.WriteLine($"Число найдено: Строка {i + 1} ; Колонка {j + 1}");
            numberFound = true;
        }
    }
}

if (numberFound != true) Console.WriteLine("Число НЕ найдено");