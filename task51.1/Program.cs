//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i<Array.GetLength(0); i++)
    {
        for(int j = 0; j<Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");
        }
    Console.WriteLine();    
    }    
}

int Diagonal (int[,] Array)
{
    int sum = 0;
    for(int i = 0, j = 0; i<Array.GetLength(0) && j<Array.GetLength(1); i++, j++)
    {
       if(i == j)
       {
        sum = sum + Array[i,j];
       }
    }
    Console.WriteLine($"Сумма элементов по диагонали: {sum}"); 
    return sum;   
}

int[,] Array1 = GetArray(rows, columns, -5, 5);
PrintArray(Array1);
Diagonal(Array1);

