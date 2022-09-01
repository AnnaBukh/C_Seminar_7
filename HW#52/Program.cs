//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //i < row, (0) - строки 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// j < col , (1) - столбцы 
        {
        matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        //if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
        //else Console.Write($"{matrix[i,j], 3}");
// вариант с помощью тернарного оператора
        Console.Write(j < matrix.GetLength(1) - 1 ?
         $"{matrix[i,j], 3}," : 
         $"{matrix[i,j], 3}");
        }
         Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrix(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();

double [] MatrixArithmMeanCol(int[,] matrix)
{
    double [] sum = new double [matrix.GetLength(1)];   // поставила тип double,  с int не работает

    double [] ArithmMeanCol = new double[matrix.GetLength(1)]; 
    
    for (int j = 0; j < matrix.GetLength(1); j++)  
    {                                      
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {                                               
        sum [j] += matrix[i,j]; 
        }
        ArithmMeanCol [j] = sum [j] / matrix.GetLength(0);
    }    
 return ArithmMeanCol;
}

double[] ArithmMeanCol1 = MatrixArithmMeanCol(array2D);

void PrintArray(double[] array)
{   
    Console.Write("Среднее арифметическое каждого столбца: "); 
for (int i = 0; i < array.Length; i++)
    {
       if (i < array.Length-1) 
    {
       Console.Write("{0:F1}",array[i] );
       //Console.Write(array[i] );
       Console.Write("  ");
       //Console.Write("  ");
    }
    else Console.Write("{0:F1}", array[i]);
       //Console.Write(array[i]);
    }
    Console.Write(".");
    Console.WriteLine();
}
PrintArray(ArithmMeanCol1);

//Console.Write("Среднее арифметическое каждого столбца: "); 
    //for (int j = 0; j < array2D.GetLength(1); j++)  
    //{
    //Console.Write(Math.Round(sum [j] / array2D.GetLength(0), 1)  + "; ");// вывод с округлением сделать