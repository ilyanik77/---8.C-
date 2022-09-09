// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int [,] CreateArray (int n, int m)
{
    int [,] arr = new int [n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr [i, j]}\t");
        }
        Console.WriteLine();
    }
    
}

int [,]  MultyArray (int[,] ar1, int[,] ar2)
{
    if (ar1.GetLength(1) != ar2.GetLength(0))
        throw new Exception("Матрицы нельзя перемножать");

    int[,] m = new int [ar1.GetLength(0), ar2.GetLength(1)];

    for (int i = 0; i < ar1.GetLength(0); ++i)
    {
        for (int j = 0; j < ar2.GetLength(0); ++j)
        {
            for (int k = 0; k < ar2.GetLength(1); ++k)
            {
                m[i, k] += ar1[i, j] * ar2[j, k];
            }
        }
    }
    return m;
    
}

int [,] Array1 = CreateArray(3, 3);
int [,] Array2 = CreateArray(3, 4);
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
int [,] Array3 = MultyArray(Array1, Array2);
PrintArray(Array3);