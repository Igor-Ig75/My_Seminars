/* Которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Введите первое число 5 Введите второе число 4
Число 5 в степини 4 = 625*/

int Step(int a, int b)  // a=2 b=3  result=2*2*2
{
int result = 1;
for(int i = 1; i <= b; i++)
result = result * a;
return result;
}
Console.Write("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());
//Console.Write(Step(n, m));
Console.Write($"Число {n} в степини {m} = {Step(n, m)}");