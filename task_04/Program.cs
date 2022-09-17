// Написать программу вычисления функции Аккермана

int Akkerman(int m, int n) // Аккермана
{
    //Console.WriteLine("A[{0},{1}]", m, n);
    if (m == 0)
        return n + 1;
    else
        if ((m > 0) && (n == 0))
            return Akkerman(m - 1, 1);
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
}

int NumberEntry()// Функция ввода числа
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите число n: ");
    return Number;
}
Console.WriteLine("Введите число m: ");
int m = NumberEntry();
Console.WriteLine("Введите число n: ");
int n = NumberEntry();
Console.WriteLine($"Функция Аккермана : = {Akkerman(m, n)}");