// Самостоятельная работа 1.
/*Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.*/

int NoreNumber()
{
    int num = new Random().Next(10,100);
    Console.WriteLine("Случайное число " + num);
    int ten = num / 10;
    int ed = num % 10;

    int max = ten, min = ed;

    if (ed > max) max = ed;

    int result = max;
    return result;

}

int number = NoreNumber();
Console.WriteLine("Это наибольшее число " + number);