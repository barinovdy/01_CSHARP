// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы 
// на их квадраты.
// Пример


// 2 3 4 3
// 4 3 4 1
// =>
// 2 9 5 4
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4


int[] CreateMatrixRndInt(int rows, int colums int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(10); ji++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}