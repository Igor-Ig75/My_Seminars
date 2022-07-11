// Задача.
/*Напишите программу, которая принимает на вход
 число (А) и выдаёт сумму чисел от 1 до А. 
   Введите положительное целое число: 5
   Выдаёт сумму чисел от 1 до 5 = 15*/

int FindSum(int a)    //  <<На Вход-int>> FindSum <<(int a)-на Выход>>
{
    int sum = 0;
    for(int current = 1; current <= a; current++) // current -текущая переменая
        sum += current; //тоже самое что sum = sum + current; когда в цикле одна команда скобки можно не ставить

    return sum;
}

Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Выдаёт сумму чисел от 1 до {num} = {FindSum(num)}");  // $ -
//Console.WriteLine(FindSum());