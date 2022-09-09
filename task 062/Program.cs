// Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] SpiralFill(int m, int n) 
{
    int [,] array = new int [n, m];
    int val = 1;
  
    //k - начальный индекс строки
    //m - конечный индекс строки
    //l - начальный индекс столбца
    //n - конечный индекс столбца 
    int k = 0, l = 0;
    while (k < m && l < n) 
    {
            
        for (int i = l; i < n; ++i) 
        {
            array[k,i] = val++;
        }
        k++;
  
            
        for (int i = k; i < m; ++i) 
        {
            array[i,n - 1] = val++;
        }
        n--;
  
            
        if (k < m) 
        {
            for (int i = n - 1; i >= l; --i) 
            {
                array[m - 1,i] = val++;
            }
            m--;
        }
  
           
        if (l < n) 
        {
            for (int i = m - 1; i >= k; --i) 
            {
                array[i,l] = val++;
            }
            l++;
        }
        
    }
    return array;
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

int [,] matrix = SpiralFill(5, 5);
PrintArray(matrix);
