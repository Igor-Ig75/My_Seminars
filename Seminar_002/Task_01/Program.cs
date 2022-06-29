/* Напишите программу, 
которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.   456->46*/
/*
int CutNumber()  // метод который возвращает
{
    int num = new Random().Next(10,1000);   // -даст случайное целое число от (min до max-1)
    Console.WriteLine("Current random number is " + num);  // - вывод числа в терминал
    int sotni = num / 100;  // удалить цифру 456 / 100 -> 4 (4.56 ,где 4 -целое число)
    int ed = num % 10;      // удалить цифру456 % 10 -> 6   (45.6 ,где 6 -(%) остаток от деления)

    int result = sotni * 10 + ed;
    return result;           // возврат 
}

int number = CutNumber();   //-для зпуска int метода CutNumber -имя метода
Console.WriteLine("Result number is " + number);  //-для выдочи результата в терминал int CutNumber метода
*/


void CutNumberVoid()     // решение задачи без возрата метода через void 
{
    int num = new Random().Next(10,1000);
    Console.WriteLine("Current random number is " + num);
    int sotni = num / 100;  // 456 / 100 -> 4 (4.56, где 4 -целое число)
    int ed = num % 10;      // 456 % 10 -> 6   (45.6, где 6(%) -остаток от деления)

    int result = sotni * 10 + ed;
    Console.WriteLine("Result number is " + result);
}

CutNumberVoid();        //  для ввывода в терминал написать имя метода 

