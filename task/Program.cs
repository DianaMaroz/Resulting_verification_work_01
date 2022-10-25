// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых маньше либо равна 3 символа.

//  Задать массив из строк
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
string [] handArray = new string[num];
FillStringArray(handArray);
Console.Write("[" +  string.Join(", ", handArray) + "]");
Console.WriteLine();
int numLen = 3; // определение максимальной длины строки для вхождения в новый массив
int NewArrayLenght = CountNewArrayLenght(handArray, numLen);
Console.WriteLine(NewArrayLenght);

// заполнение массива вручную
void FillStringArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}. Введите значение массива");
        array[i] = Console.ReadLine();
    }
}

// определение длины нового массива
int CountNewArrayLenght (string [] arr, int numLenght)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= numLenght) counter++;
        i++;
    }
    return counter;
}

