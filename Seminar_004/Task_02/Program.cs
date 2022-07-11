/* Напишите программу, которая принимает на 
вход число и выдаёт количество цифр в числе.
Введите число 3456
4*/

int Kolich(int num)
{
int result = 1; 
int i = 1;
while(num / i > 10)
{
i = i * 10;
result++;
}
return result;
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Kolich(n));
Console.WriteLine($"Выдаёт количество цифр в числе {n} = {Kolich(n)}"); 
 