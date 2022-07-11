/* Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
Введите число 3. В число 3 выдаёт 
произведение чисел от 1 до = 6 */

int Proisv(int N)
{
int result = 1;

for(int i = 1; i <= N; i++)
    result = result * i;
return result;
}

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Proisv(n));
Console.WriteLine($"Число {n} выдаёт произведение чисел от 1 до = {Proisv(n)}"); 
 
