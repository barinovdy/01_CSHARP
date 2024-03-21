// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из средних 
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1  => [3 3 5]
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}"); //5 - количество символов для вывода
        }
        //Console.WriteLine("   |");
        Console.WriteLine();
    }
}

double[] ArraySumEverage(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average = average + matrix[i, j];
        }
        average = average / matrix.GetLength(1);
        array[i] = average;
    }
    return array;
}

int[,] matrixNew = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrixNew);

double[] averageArray = ArraySumEverage(matrixNew);
for (int i = 0; i < averageArray.Length; i++)
    {
        Console.Write($"{averageArray[i]} ");
    }
