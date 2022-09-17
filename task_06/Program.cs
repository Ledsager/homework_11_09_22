// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void ArrayMN(int m, int n, int l) // расчет последовательности
{
    if (l == 0)
        return;
    else
    {
        Console.Write((n + m) + " ");
        ArrayMN(n, n+m, l - 1);
    }
}

int NumberEntry()// Функция ввода числа
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите число n: ");
    return Number;
}
Console.WriteLine("Введите первый элемент m: ");
int m = NumberEntry();
Console.WriteLine("Введите второй элемент n: ");
int n = NumberEntry();
Console.WriteLine("Введите длину выводимой последовательности l(l>=1): ");
int l = NumberEntry();
Console.Write($"последовательность равна : ");
ArrayMN(m, n, l);
