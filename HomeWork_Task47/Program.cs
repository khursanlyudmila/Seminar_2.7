/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] InitArray(int str, int columns)
{
    double[,] result = new double[str,columns];
    Random rnd = new Random();

    for (int i = 0; i < str; i++)
        for (int j = 0; j < columns; j++)
        {

            {
                result[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
          
        }
    return result;
}

void PrintArray(double [,] array)
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
double[,] matrix = InitArray(str, columns);
PrintArray(matrix);
