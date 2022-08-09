/* Суперсдвиг
(Время: 1 сек. Память: 16 Мб Сложность: 20%)
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю 
последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное
и влево, если отрицательное.
(1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).   */

Console.Clear();
int n = new Random().Next(1, 100);    // количество элементов массива
Console.WriteLine($"Количество элементов массива  n = {n}");
int k = new Random().Next(-100, 100); // циклический сдвиг на k элементов
Console.WriteLine($"циклический сдвиг на k элементов = {k}");
int neg = -100;                 //минимальное значение массива
int pos = 100;                  //максимальное значение массива

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
int[] randArray = RandomArray(n, neg, pos);
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", randArray) + "]");

int[] CyclicShiftArray(int[] array, int shift)
{
    int[] cyclicarray = new int[array.Length];
    int shiftabs = Math.Abs(shift);
    if (shift > 0)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {

            if (j< array.Length-shiftabs)
            {
                cyclicarray[j+shiftabs]  = array[j];
            }
            else
            {
                cyclicarray[j- j + count] = array[j];
                count++;
            }

        }
    }
    else if (shift < 0)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {

            if (j + shiftabs < array.Length)
            {
                cyclicarray[j] = array[j + shiftabs];
            }
            else
            {
                cyclicarray[j] = array[j - j + count];
                count++;
            }

        }
    }
    return cyclicarray;
}
int[] shiftArray = CyclicShiftArray(randArray, k);
Console.WriteLine();
Console.WriteLine("Конечный массив: [" + string.Join(", ", shiftArray) + "]");
Console.WriteLine();
