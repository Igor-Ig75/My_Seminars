/*  int a = 5; целое число
double b = 5.4;  вещественое число
string c = "Привет"; какой либо текст  */ 

/* int nam = 5;
Console.WriteLine("My number is" + nam); // если "My number is" в ковычках то выведится текст, 
//знак + склеиваеи этистроки */
/*
int number;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваш число - " + number);
*/

/* Задача
Не обходимо запросить у пользователя два целых числа.
Является первое число квадратом второго числа. */

/*
int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)  // одно = -это присваевание, два == -это равенство.
{
    Console.WriteLine("First number is a quad of second nuber");
}
else
{
     Console.WriteLine("First number is not a quad of second nuber");
}  */

/* Задача1:
Напишите программу, которая будет выдавать название дня недели по заданному номеру */

/*
int number;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine("Понедельник");
}
if(number == 2)
{
    Console.WriteLine("Вторник");
}
if(number == 3)
{
    Console.WriteLine("Среда");
}
if(number == 4)
{
    Console.WriteLine("Четверг");
}
if(number == 5)
{
    Console.WriteLine("Пятница");
}
if(number == 6)
{
    Console.WriteLine("Суббота");
}
if(number == 7)
{
    Console.WriteLine("Воскресение");
}
if(number > 7 || number < 1)        // "||" -это логическое или
{
    Console.WriteLine("Вы набрали не првельное число");
}
*/

   /*   Задача2:
     Напишите программу, которая на вход принимает число и выдаёт его квадрат.  */
/*
int number;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Квадрат вашего числа равен: " + number * number);
*/

/* Задача
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. */
/*
int n, current;

Console.Write("Введите число: "); // Imput a number-(Введите число)
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++; //current = (current + "")

}
*/