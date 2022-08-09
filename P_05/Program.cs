// Урок 5. Пузырьковая сортировка
Console.Clear();
Console.WriteLine("Вариант сортировки выбором числового массива:");
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
Console.WriteLine($"Введите {n} чисел: ");
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// Сортировка
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();