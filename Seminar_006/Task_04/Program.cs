/*Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.*/

void PrintArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int [] Fibonacci(int n)
{
    int[] newArreay = new int[n];
    Console.WriteLine("Создание массива здесь: ");
    newArreay[0] = 0;
    newArreay[1] = 1;
    for(int i = 2; i < n; i++)
    {
        newArreay[i] = newArreay[i - 1] + newArreay[i - 2];
    }
    return newArreay;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(Fibonacci(num));
