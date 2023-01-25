/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


//метод для инициализации массива рандомными числами
int[,] InitArray(int str, int columns)
{
    int[,] result = new int[str,columns];
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

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write($"{array[i,j]} ");
            }
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
Console.WriteLine("------------------------------------");

for (int j = 0; j < columns; j++)
{
    double summ = 0;
    for (int i = 0; i < str; i++)
    {
        summ += matrix[i,j];
    }
    Console.Write($"{ summ / str} ");
}
Console.ReadLine();
