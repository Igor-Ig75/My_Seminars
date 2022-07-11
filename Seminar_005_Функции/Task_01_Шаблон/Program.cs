

// метод генерирует массивом слуайными элементами для целых чисел
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

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значения элементов ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элементов ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateRandomArray(size, min, max);    // метод генерирует массивом слуайными элементами для целых чисел
int [] array2 = CreateArray(size);                    // метод генерирует массивом который водит даные пользователь
PrintArray(array1);                                   //метод который печатает или выводит на экран
PrintArray(array2);                                   //метод который печатает или выводит на экран


//--------------------------------Второй вариант---------------------------------------------------------------------------------------------------

/*
void FillArray(int[] collection, int rangeStart, int rangeEnd)
{
    int length = collection.Length;

    for(int i = 0; i < length; i++)
        collection[i] = new Random().Next(rangeStart, rangeEnd);
}

*/

int [] FillArray(int size, int minValue, int maxValue)   
{
    int [] newArray = new int[size];
    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void PrintArray1(int[] col)
{
    int count = col.Length;
    Console.Write("[ ");
    for(int position = 0; position < count; position++)
        Console.Write(col[position] + ", ");
    Console.Write("]");
}

//int[] array = new int[10];             //работае при void FillArray(int[] collection, int rangeStart, int rangeEnd)
//FillArray(10, -10, 10);                //работае при void FillArray(int[] collection, int rangeStart, int rangeEnd)
int[] array = FillArray(10, -10, 10);   // размер массива, минимальное значение, максимальное значения
PrintArray1(array);


