// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце

Console.Write("Введите первое число: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0 ,10);
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}
System.Console.WriteLine("_____________");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    System.Console.WriteLine(sum/ matrix.GetLength(0)+ " ");
}