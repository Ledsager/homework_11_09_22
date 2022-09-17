// Найти сумму цифр числа

int DigitsSum(int n)// Сумма цифр в числе
{
    if (n == 0) return 0;
    return n % 10 + DigitsSum(n / 10);
}

int NumberEntry()// Функция ввода числа
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите число n: ");
    return Number;
}
Console.WriteLine("Введите число n: ");
int n = NumberEntry();
Console.WriteLine($"Сумма цифр в числе {n} : = {DigitsSum(n)}");