// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] CreateArray (int a, int b, int c)
{
    int [,,] arr = new int [a, b, c];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr [i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return arr;
}

void PrintArray (int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($"Вложенный массив № {i + 1}");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr [i, j, k]}\t");
            }
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}

int [,,] matrix = CreateArray(3, 2, 2);
PrintArray(matrix);