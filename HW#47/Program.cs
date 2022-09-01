//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col]; 
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //i < row, (0) - строки 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// j < col , (1) - столбцы 
        {
        matrix[i,j] = rand.Next(-10, 10 + 1) + rand.NextDouble();// double rand = rand.NextDouble()*(max - min) + min;
        matrix[i,j] = Math.Round(matrix[i,j], 1);                // martix[i,j] = Math.Round(rand, 2);
        }
    }
    return matrix;
}

double[,] arr  = CreateMatrixRndDouble(3, 4, -9, 9);

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5},");
        else Console.Write($"{matrix[i,j], 5}");
        }
         Console.WriteLine("]");
    }
}

PrintArray(arr);

