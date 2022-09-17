// Написать программу возведения числа А в целую стень B

int Stepen(int m, int n) // Возведение в степень
{
    if (n == 0)
        return 1;
    else
        return m * Stepen(m, n - 1);

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
Console.WriteLine("Введите степень n: ");
int n = NumberEntry();
Console.WriteLine($"{m} в степени {n} = {Stepen(m, n)}");
