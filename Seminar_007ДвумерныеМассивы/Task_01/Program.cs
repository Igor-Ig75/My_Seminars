/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.*/

int[,] CreatRondom2dArray(int rows, int columns, int minValue, int maxValue)   // int[,] возвращает в основную программу, CreatRondom2dArray() принимает на вход
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}

void Print2dArray(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
       { 
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

            Console.WriteLine();
        }
}

Console.Write("Ведите количство строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите количство столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRondom2dArray(m,n,min,max);
Print2dArray(myArray);