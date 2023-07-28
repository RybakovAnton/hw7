// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Введите первое число: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите первое число: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

for (int i = 0; i < matrix.GetLongLength(0); i++)
{
    for (int j = 0; j < matrix.GetLongLength(1); j++)
    {
        matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        System.Console.Write(matrix[i, j]+ "  ");
    }   
    System.Console.WriteLine();
}

