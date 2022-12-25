/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

// Проверка на правильность ввода диапазона
bool CheckNumber(int m, int n)
{
    bool result = false;
    while (!result)
    {
        if (m > n)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Ввели не верный диапазон. Введите правильный диапазон от m до n!");
        }
    }
    return result;
}

//Рекурсивный метод
int RecursNumRange(int min, int max)
{
    int count = min;
    int sum = 0;
    if (count <= max)
    {
        sum += min + RecursNumRange(min + 1,max);
        count++;
    }

    return sum;
}

while (true)
{
    int m = GetNumber("Задайте значение (натуральное число) диапазона {M,N} M= ");
    int n = GetNumber("Задайте значение (натуральное число) диапазона {M,N} N= ");
    if (n <= m)
    {
        Console.WriteLine("Ввели не верный диапазон. Введите правильный диапазон от m до n!");
    }
    else
    {
        Console.WriteLine($"Сумма значений от [M до M] ={RecursNumRange(m,n)}");
        break;
    }
}