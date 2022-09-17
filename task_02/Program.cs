// Найти сумму элементов от M до N, N и M заданы
int SumNaturNumber(int m, int n)
{
    if (m == n+1)
        return 0;
    return m + SumNaturNumber(m + 1, n);
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
if(m>n)
{
    int a=m;
    m=n;
    n=a;
}
Console.WriteLine(SumNaturNumber(m, n));