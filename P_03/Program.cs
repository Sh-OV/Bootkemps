int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(" ", array));         // функция Join выводит (соединяет) все элементы массива через какойто разделитель, в данном примере разделитель пробел
Console.WriteLine(array[3]);
// Сложность алгоритма О(n) - количество операций n

// Возьмем массив [3, 2, 4, 1, 5] какой будет О(n), если надо найти сумму массива?
// А если мы отсортируем массив (конечно мы потратим время, но! мы сможем найти сумму массива за 1 операцию)
// [1, 2, 3, 4, 5] => O (n * log2 n)
// ((n + 1)/2) * n (где n - количество элементов в массиве) => O(1)
// Но не всегда n > n * log2 n + 1 (не всегда сортировка + действие быстрее цикла с перебором всех элементов)
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += array[i];
}
Console.WriteLine(sum);

// O(k^2)
int k = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[k, k];
for (int i = 1; i < k; i++)
{
    for (int j = 1; j < k; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
}
// Сократить время работы алгоритма можно если убрать нахождение повторяющихся элементов
for (int i = 1; i < k; i++)
{
    for (int j = 1; j < k; j++)
    {
        if (i + j <= n)
        {
            matrix[i, j] = i * j;
            matrix[j, i] = i * j;
        }
        Console.Write(i * j);
        Console.Write("\t");
    }
}
// Все равно время заполнения будет O(k^2)

for (int i = 0; i < k; i++)
{
    for (int j = i; j < k; j++)
    {
        if (i + j <= n)
        {
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = matrix[i, j];
        }
    }
}
// Время заполнения будет O(k^2 / 2)