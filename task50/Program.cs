//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите строку массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array1 = GetArray(2, 3, -5, 5);
PrintArray(Array1);

int[,] GetArray(int m, int n, int minValue, int maxValue)
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
            Console.Write($"{Array[i,j]} ");
        }
    Console.WriteLine();    
    } 

    if(rows<Array.GetLength(0) || columns<Array.GetLength(1))
    {
        Console.WriteLine($"{Array[rows,columns]}");
    }
    else
    {
        Console.WriteLine($"{rows}{columns} - Такого элемента в массиве нет ");
    }          
}