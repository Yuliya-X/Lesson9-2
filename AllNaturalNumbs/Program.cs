// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Подзадачи: ввод числа руками, вывод n - 1 

int Input(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumber(int N)
{
    if(N == 0) return;
    Console.Write(N + ", ");
    NaturalNumber(N - 1);
}


int N = Input("Введите число N ");
NaturalNumber(N);
