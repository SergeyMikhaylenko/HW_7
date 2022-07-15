// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int [,] matrix = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum=0;
    for (int i =0; i < matrix.GetLength(0); i++)
    {
    sum+=matrix[i, j];
    }
    Console.Write($"{sum / matrix.GetLength(0)} ");
}