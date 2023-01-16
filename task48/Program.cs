//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
//Выведите полученный массив на экран. m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Massive(int m, int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = i + j;       
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
            Console.Write($"{Array[i,j]} ");       
        }
    Console.WriteLine();    
    }   
}

int[,] array = Massive(rows,columns);
PrintArray(array);