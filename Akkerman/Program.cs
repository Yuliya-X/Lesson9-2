// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// подзадачи: ввод значений руками, вывод натурального числа A(m,n)

// функция Аккермана(m, n) из Вики
//   если m = 0
//   вернуть n + 1
//   иначе, если n = 0 
//   вернуть Аккермана (m - 1, 1)
//   и ещё вернуть Аккермана(m - 1, Аккермана(m, n - 1))

int Input(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int M = Input("Введите число M ");
int N = Input("Введите число N ");
Console.Write($"{Akkerman(M, N)}");