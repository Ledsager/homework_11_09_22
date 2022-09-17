// Показать натуральные числа от M до N, N и M заданы

void NaturNumberReverse(int m, int n)
{
    if (m <= n - 1)
        return;
    Console.Write(m + " ");
    NaturNumberReverse(m - 1, n);
}
void NaturNumber(int m, int n)
{
    if (m >= n + 1)
        return;
    Console.Write(m + " ");
    NaturNumber(m + 1, n);
}

Console.WriteLine("ВВедите диапазон[m,n]");
int m;
Console.WriteLine("Input m: ");
while (!int.TryParse(Console.ReadLine(), out m))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
int n;
Console.WriteLine("Input n: ");
while (!int.TryParse(Console.ReadLine(), out n))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");
Console.WriteLine();
if (m > n)
    NaturNumberReverse(m, n);
else
    NaturNumber(m, n);