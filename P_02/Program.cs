// Алгоритм Евклида:
// НОД - найти наибольший общий делитель
Console.WriteLine("Для того, чтобы рассчитать НОД и НОК введите 2 числа");
Console.Write("Первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int nod = 0;
int count = m * n;
while (n != m)
{
    if (n > m) n = n - m;
    else m = m - n;
}
nod = n;
Console.WriteLine(nod);

// НОК - наименьшее общее кратное
int nok = count / nod;
Console.WriteLine(nok);
Console.WriteLine();