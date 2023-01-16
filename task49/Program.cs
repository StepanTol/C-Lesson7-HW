//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
// выглядел вот так:           Новый массив будет выглядеть 
//1 4 7 2      1 4 7 2
//5 9 2 3      5 81 2 9
//8 4 2 4       8 4 2 4                      

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue+1);
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

void FillArray(int[,] Array)
{
    for(int i = 0; i<Array.GetLength(0); i = i+2)
    {
        for(int j = 0; j<Array.GetLength(1); j = j+2)
        {
            Array[i,j] = Array[i,j] * Array[i,j]; 
        }
    Console.WriteLine();    
    }
}

int[,] Array1 = GetArray(rows, columns, -10, 10);
PrintArray(Array1);
FillArray(Array1);
PrintArray(Array1);