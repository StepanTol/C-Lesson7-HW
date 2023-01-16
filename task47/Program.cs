//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] GetArray (int m, int n)
{
    double[,] result = new double[m,n];
    Random rand = new Random();
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = rand.NextDouble() + rand.Next(1,20);
            result[i,j] = Math.Round(result[i,j],2);
            //Console.Write($"{0,5:F2}", result[i,j]);
        }
    }
    return result;
}

void PrintArray(double[,] Array)
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

double[,] Array = GetArray(rows, columns);
PrintArray(Array);