// Задача 48: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные, и замените
// эти элементы на их квадраты.


int[,] CreateMatrixRndInt(int raws, int columns, int min, int max)
{
    int[,] matrix = new int[raws, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }


    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i,j], 6} ");
        }
        Console.WriteLine("|");
    }
}

void ChangeMatrixSquareInt(int raws, int columns, int min, int max)
{
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i%2==0&&j%2==0)
            matrix[i, j] = (matrix[i, j]*matrix[i, j]);
        }
    }
    return matrix;
}

int[,] array2D=CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
ChangeMatrixSquareInt(array2D);
PrintMatrix(array2D);