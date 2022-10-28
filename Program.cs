//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

int[,] OrderRows(int [,] array)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }    
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = OrderRows(myArray);
Console.WriteLine();
Show2DArray(myArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

void MinSumRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        minRow += array[0, i];
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            sumRow += array[j, k];
            {
                if (sumRow < minRow)
                {
                    minRow = sumRow;
                    minSumRow = i;
                }
                sumRow = 0;
            }
            
                       
        }
        
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
    
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
MinSumRow(myArray);
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


int[,] ArrayForMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}

void Show2DArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] FinishMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      array[i,j] = sum;
    }
  }
  return array;
}

Console.WriteLine("Введите число строк первой и второй матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой и второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = ArrayForMatrix(m,n,min,max);
Console.WriteLine($"Первая матрица: ");
Show2DArray(firstMatrix);

int[,] secondMatrix = ArrayForMatrix(m,n,min,max);
Console.WriteLine($"Вторая матрица: ");
Show2DArray(secondMatrix);

int[,] myArray = ArrayForMatrix(m,n,min,max);
int[,] endMatrix = FinishMatrix(firstMatrix, secondMatrix, myArray);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2DArray(endMatrix);

