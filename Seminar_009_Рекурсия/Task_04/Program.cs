/*Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.*/ 

 
int SumOfDigits(int a, int b)
{
        if(b > 1)
            return a * SumOfDigits(a, b - 1);
        return a;
}

Console.WriteLine(SumOfDigits(4, 3));


