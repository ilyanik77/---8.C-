// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [,] SortMatrix (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                  int temp = arr[i, k + 1];
                  arr[i, k + 1] = arr[i, k];
                  arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

int [,] newMatrix = CreateArray(3, 4);
PrintArray(newMatrix);
System.Console.WriteLine();
int [,] sortArray = SortMatrix(newMatrix);
PrintArray(sortArray);