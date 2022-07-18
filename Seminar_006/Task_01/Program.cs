/*Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.) */

//===============1 ВЕРСИЯ===================================================
/*
int[] ReverseArray1(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 -i] = temp;
    }
    return array;
}
*/
//===============2 ВЕРСИЯ===============================================================
/*
int[] ReverseArray2(int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 -i] = temp;
    }
    return array;
}
*/
//================3 ВЕРСИЯ==============================================================
/*
int[] ReverseArray3(int[] array)
{
    int lastIdex = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[lastIdex - i];
        array[lastIdex -i] = temp;
    }
    return array;
}
*/
//================4 ВЕРСИЯ==============================================================
/*
int[] ReverseArray(int[] array)
{
    int i = 0, j = array.Length - 1;

    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
}
*/
//================5 ВЕРСИЯ==============================================================

int[] ReverseArray5(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
int [] myArray = {3, 6, 5, 7, 2, 5, 1};
myArray = ReverseArray5(myArray);

for(int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");