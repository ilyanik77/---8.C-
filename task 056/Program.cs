// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRow (int [,] arr, int i)
{
    int sum = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        
        sum += arr [i, j];
    }
    return sum;
    
}

int [,] newMatrix = CreateArray(3, 4);
int minSumRow = 0;
int sumLine = SumRow(newMatrix, 0);
for (int i = 1; i < newMatrix.GetLength(0); i++)
{
    int tempSumLine = SumRow(newMatrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumRow = i;
    }
}


PrintArray(newMatrix);
Console.WriteLine();
SumRow(newMatrix, 0);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");        
