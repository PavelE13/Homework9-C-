/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//Метод провеки на валидность вводимых значений
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не натуральное число>0. Введите правильное число!");
        }
    }
    return result;
}

//Рекурсивный метод
string RecursNum(int number)
{
    string result=String.Empty;
    if (number >= 1) 
    {
        result+=  number + " , " + RecursNum(number-1);
    }
return result;
}
int n = GetNumber(" Задайте значение (натуральное число) N= ");
Console.WriteLine(RecursNum(n));