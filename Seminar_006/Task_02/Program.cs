/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
18/2-> 9 0
 9/2-> 4 1
 4/2-> 2 0
 2/2-> 1 0
 1/2-> 0 1

18 -> 10010
*/
string ChangeDigitSystem(int num)
{
    string resultNumder = string.Empty;

    while(num > 0)
    {
        resultNumder = num % 2 + resultNumder;
        num /= 2; // num = num / 2;
    }
    return resultNumder;
}

Console.WriteLine(ChangeDigitSystem(18));