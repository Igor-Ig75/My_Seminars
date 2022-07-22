/*Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.*/ 

void ShowNums(int n)
{
    if(n > 1)
    {
        ShowNums(n - 1);
    
    }
    Console.Write(n + " ");
}
ShowNums(5);     // Результат 1 2 3 4 5 



// void ShowNums(int n)
// {
//     if(n > 1)
//     {
//         Console.Write(n + " ");
//         ShowNums(n - 1);
    
//     }
//     Console.Write(n + " ");
// }
// ShowNums(5);   // Результат 5 4 3 2 1 2 3 4 5 

