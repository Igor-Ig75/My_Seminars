//Задача
/*Которая выводит номер четверти и выводит диапазон 
значения координат возможней этой четверти
*/
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
        Console.WriteLine("Thes numder is uncorrect!");
}

Console.Write("Input numdes of quart; ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
