// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5     7  -2    -0,   2
//   1  -3,3   8    -9,   9
//   8     7,  8  -7,1    9


void FillArray(double [,] array)
{
    Random rand = new Random();
    for (int i = 0;i< array.GetLength(0);i++)
    {
        
        for (int j = 0;j<array.GetLength(0);j++ )
        {
            array[i,j] = Math.Round(rand.NextDouble()*(100-(-100))+(-100),2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(0);j++)
        {
            Console.Write($"{array[i,j],6} \t");
        
        }
        Console.WriteLine();
    }
}





Console.WriteLine("Введите колтичество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows,cols];
FillArray(array);
PrintArray(array);