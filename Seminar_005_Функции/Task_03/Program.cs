
/*Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.  *умножить на -1
*/
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)   
{
    int [] newArray = new int[size];
    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

// метод генерирует массивом который водит даные пользователь
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

//метод который печатает или выводит на экран
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

int[] ReplacingSigns(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;

    return newArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значения элементов ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элементов ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size, min, max);
PrintArray(array);
int[] ReplacSigns = ReplacingSigns(array);
PrintArray(ReplacSigns);
*/

///---------------------Второй вариант-----массив случайных чисел------------------------------------

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

int[] ReplacingSigns(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;

    return newArray;
}

int[] array = new int[10];

FillArray(array, -10, 100);
PrintArray(array);
Console.WriteLine();
int[] ReplacSigns = ReplacingSigns(array);
PrintArray(ReplacSigns);