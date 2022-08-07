// Урок 4. Алгоритм «Сортировка выбором»

Console.Clear();
Console.WriteLine("Вариант сортироаки выбором числового массива:");
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
            Console.WriteLine($"i = {i}; j = {j}; minIndex = {minIndex}");
    }
    int temp;
    temp = array[minIndex];
    Console.WriteLine($"i = {i}; temp = {temp}; array[i] = {array[i]}");
    array[minIndex] = array[i];
    array[i] = temp;
    
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();

Console.WriteLine("Вариант сортироаки выбором строкового массива:");
Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
string[] starray = new string[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите строку: ");
    starray[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", starray) + "]");
// Сортировка
for (int i = 0; i < m - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < m; j++)
    {
        if (starray[j].Length < starray[minIndex].Length)
            minIndex = j;
            Console.WriteLine($"i = {i}; j = {j}; minIndex = {minIndex}");
    }
    string temp;
    temp = starray[minIndex];
    Console.WriteLine($"i = {i}; temp = {temp}; starray[i] = {starray[i]}");
    starray[minIndex] = starray[i];
    starray[i] = temp;
    
}
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", starray) + "]");
Console.WriteLine();