// Урок 4. Алгоритм «Сортировка выбором»
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// Сортировка
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[minIndex])
            minIndex = j;
    }
    int temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();