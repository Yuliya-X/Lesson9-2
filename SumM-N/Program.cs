// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// подзадачи: ввод значений руками, вывод суммы промежуточных значений 

int Input(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if(M == N) return N;
    else
    {
        return M + SumNumbers(M + 1, N);    
    }
}

int M = Input("Введите число M ");
int N = Input("Введите число N ");
Console.Write($"Сумма = {SumNumbers(M, N)}");