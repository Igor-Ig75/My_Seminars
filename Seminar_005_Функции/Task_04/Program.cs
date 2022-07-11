/*Задайте одномерный массив из 20 случайных чисел. 
Найдите количество элементов массива -Array[i], значения которых лежат в отрезке [10,99].
   *использовать миним. и максим.*/
/*

void FillArray(int[] collection, int rangeStart, int rangeEnd)
{
    int length = collection.Length;

    for(int i = 0; i < length; i++)
        collection[i] = new Random().Next(rangeStart, rangeEnd);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Console.Write("[ ");
    for(int position = 0; position < count; position++)
        Console.Write(col[position] + ", ");
    Console.Write("]");
}

//Решение задачи
int QuantityEliment(int[] newArray)
{
    int count = 0;

    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] >= 10 && newArray[i] <= 99) count++;  //элементов массиваnew-Array[i]

    return count;
}

int[] array = new int[20];

FillArray(array, 1, 200);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество элементов массива = " + QuantityEliment(array));

*/
//-------------------------------------ВТОРОЙ ВАРИАНТ------------------------------------------------------------------------------------------------

int [] CreateRandomArray(int size, int minValue, int maxValue)   
{
    int [] newArray = new int[size];
    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int[] CreateArray(int size)
{
    int [] newArray = new int[size];

    Console.WriteLine("Создание массива:");
    for(int i =0; i < size; i++)
    {
        Console.Write($"Входной {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    Console.Write("[ ");

    for(int position = 0; position < count; position++)
        Console.Write(col[position] + ", ");

    Console.Write("]");
    Console.WriteLine();
}

//Решение задачи
int QuantityEliment(int[] newArray)
{
    int count = 0;

    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] >= 10 && newArray[i] <= 99) count++;  //элементов массиваnew-Array[i]

    return count;
}

int size = 20;    
//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально значения элементов ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение элементов ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size, min, max);
PrintArray(array);
Console.WriteLine("Количество элементов массива = " + QuantityEliment(array));