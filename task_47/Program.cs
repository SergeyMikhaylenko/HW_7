// Задача 47: Задайте двумерный массив
// размером m×n, заполненный случайными вещественными числами.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, columns];
Random RealNumber = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

         matrix[i, j] = RealNumber.Next(-26, 26) / 10.0 ;

        Console.Write(matrix[i, j] +"\t" );
    }
    Console.WriteLine();
}