// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int [,] array)
{
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(1);j++ )
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j],3} \t");
        
        }
        Console.WriteLine();
    }
}


void FindAvgCols(int [,] array)
{

    for (int j = 0;j< array.GetLength(1);j++)
    {
        {
            double sum = 0;
            for (int i = 0;i< array.GetLength(0);i++)
            {
                sum += array[i,j];    
            }
            Console.WriteLine($"Среднее арифметическое столбца {j+1} равно: {Math.Round(sum/array.GetLength(0),2)}");
        }        
    }
}




Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindAvgCols(array);