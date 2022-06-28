/* Напишите программу, 
которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.   456->46*/

int CutNumber()  // метод который возвращает
{
    int num = new Random().Next(10,1000);
    Console.WriteLine("Current random number is " + num);
    int sotni = num / 100;  // 456 / 100 -> 4 (4.56, где 4 -целое число)
    int ed = num % 10;      // 456 % 10 -> 6   (45.6, где 6(%) -остаток от деления)

    int result = sotni * 10 + ed;
    return result;
}

void CutNumberVoid()
{
    int num = new Random().Next(10,1000);
    Console.WriteLine("Current random number is " + num);
    int sotni = num / 100;  // 456 / 100 -> 4 (4.56, где 4 -целое число)
    int ed = num % 10;      // 456 % 10 -> 6   (45.6, где 6(%) -остаток от деления)

    int result = sotni * 10 + ed;
    Console.WriteLine("Result number is " + result);
    //Console.WriteLine("Result number is " + number);
    //return result;      - для int CutNumber метода
}

CutNumberVoid();
/*int number = CutNumber();   -для зпуска int CutNumber метода
Console.WriteLine("Result number is " + number);  -для выдочи результата в терминал int CutNumber метода
*/
