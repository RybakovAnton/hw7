// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите первое число: ");
int rows = Convert.ToInt32(Console.ReadLine())-1;

Console.Write("Введите второе число: ");
int columns = Convert.ToInt32(Console.ReadLine())-1;

int n = 8; 
int m = 8; 

int[,] matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0 ,10);
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}

if (rows < 0 || rows > matrix.GetLength(0)-1 || columns < 0 || columns > matrix.GetLength(1)-1)
{
    Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = "+ matrix[rows, columns]);
}
