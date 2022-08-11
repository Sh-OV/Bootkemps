// Урок 6. Быстрая сортировка
/*
1. arr = {1, 0, -6, 2, 5, 3, 2} 
2. pivot = arr[6]  (опорный элемент)
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
Console.Clear();
Console.WriteLine("Вариант быстрой сортировки, начиная с последнего элемента: ");
int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
Console.WriteLine($"Начальный массив [{string.Join(", ", arr)}]");
QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Отсортированный массив [{string.Join(", ", arr)}]");

static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}
static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
static void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}

Console.WriteLine();
Console.WriteLine("Вариант быстрой сортировки, начиная с первого элемента: ");
int n = new Random().Next(6, 12);    // количество элементов массива
Console.WriteLine($"Количество элементов массива  n = {n}");
int neg = -15;                 //минимальное значение массива
int pos = 15;                  //максимальное значение массива

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
Console.WriteLine("Начальный массив: [" + string.Join(", ", randArray) + "]");

int[] QuickSortStart(int[] inputArrayS, int minIndexS, int maxIndexS)
{
    if (minIndexS >= maxIndexS) return inputArrayS;
    int pivotS = GetPivotIndexStart(inputArrayS, minIndexS, maxIndexS);
    QuickSortStart(inputArrayS, minIndexS, pivotS - 1);
    QuickSortStart(inputArrayS, pivotS + 1, maxIndexS);
    return inputArrayS;
}
int GetPivotIndexStart(int[] inputArrayS, int minIndexS, int maxIndexS)
{
    int pivotIndexS = maxIndexS + 1;
    for (int i = maxIndexS; i >= minIndexS; i--)
    {
        if (inputArrayS[i] > inputArrayS[minIndexS])
        {
            pivotIndexS--;
            SwapStart(inputArrayS, pivotIndexS, i);
        }
    }
    pivotIndexS--;
    SwapStart(inputArrayS, minIndexS, pivotIndexS);
    return pivotIndexS;
}
void SwapStart(int[] inputArrayS, int leftValueS, int rightValueS)
{
    int tempS = inputArrayS[leftValueS];
    inputArrayS[leftValueS] = inputArrayS[rightValueS];
    inputArrayS[rightValueS] = tempS;
}
int[] quickSortStart = QuickSortStart(randArray, 0, randArray.Length - 1);
Console.WriteLine("Конечный массив: [" + string.Join(", ", quickSortStart) + "]");