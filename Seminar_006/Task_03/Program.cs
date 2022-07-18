/*Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

void PrintArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

void Tri(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

//=============================================================
/*
bool Tri(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.WriteLine(Tri(1,2,2));
*/
//==========================================================
/*
bool Tri(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

bool isTri = false;
isTri = Tri(4,2,3);

Console.WriteLine(isTri);
*/
//==========================================================
/*
bool Tri(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
bool isTri = false;
isTri = Tri(1,2,3);

Console.WriteLine(isTri);

*/

//double num = Convert.ToDouble(Console.ReadLine());

//double[] array = new double[size];

/*   double num = new Random().NextDouble();
         5.4    =         5.0 + 0.4   */






