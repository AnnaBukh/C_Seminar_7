// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет


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

int[,] array2D = CreateMatrix(3, 4, -9, 9);
PrintMatrix(array2D);


void RowColValue (int[,] matrix)
{
Console.Write("Введите номер строки: ");
int rowm = Convert.ToInt32(Console.ReadLine()) - 1; // номер строки  - 1 - нумерация с "0" 

Console.Write("Введите номер столбца: ");
int colm = Convert.ToInt32(Console.ReadLine()) - 1;

if (rowm < 0 | rowm > matrix.GetLength(0) -1 | colm < 0 | colm > matrix.GetLength(1) -1) // если значения меньше нуля, если больше длины массива
    Console.WriteLine("Такого элемента в массиве нет");
else 
     Console.WriteLine($"Искомый элемент массива :  {matrix[rowm, colm] }");
}

RowColValue(array2D);