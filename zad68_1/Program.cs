/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

//Метод провеки на валидность вводимых значений
int GetNumberM(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не натуральное число <4 для функции Аккермана. Введите правильное число!");
        }
    }
    return result;
}

//Метод провеки на валидность вводимых значений
int GetNumberN(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 11)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не натуральное число <4 для функции Аккермана. Введите правильное число!");
        }
    }
    return result;
}

//Метод рачето Аккермана
int FunctionAkkerman(int m, int n)
{
    int funkAk = 0;
    if (m == 0) funkAk = n + 1;
    if (m > 0 && n == 0) funkAk = FunctionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) funkAk = FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return funkAk;
}

Console.WriteLine("Внимание! При вводе значения m>= 4 и n>=11 результатом будет Stack Overfow! Диапазоны отсечены!");
int mnumber = GetNumberM("Задайте значение (натуральное число) функции Аккермана {m,n} m= ");
int nnumber = GetNumberN("Задайте значение (натуральное число) функции Аккермана {m,n} n= ");
Console.WriteLine($"Функция Аккермана A({mnumber},{nnumber})={FunctionAkkerman(mnumber, nnumber)}");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();