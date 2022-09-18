// Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.

int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-1000,1000);
    }
    return result;
}

int[] maxMinIndex(int[] array)
{
    int[] result = new int[2];
    if (array[0] < array[1]) 
    {
        result[0] = 0;
        result[1] = 1;
    }
    else 
    {
        result[0] = 1;
        result[1] = 0;
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > array[result[1]]) result[1] = i;
        else if (array[i] < array[result[0]]) result[0] = i;
    }
    return result;
}

int average(int[] array)
{
    int result = 0;
    int summ = 0;
    int count = 0;
    foreach(int item in array)
    {
        summ+=item;
        count++;
    }
    result = summ / count;
    return result;
}

int[] sortArray(int[] array)
{
    int[] sorted = array;
    int temp = 0;
    for (int i = 0; i <sorted.Length - 1; i++)
    {
        for (int j = 0; j < sorted.Length - i - 1; j++)
        {
            if (sorted[j] > sorted[j+1])
            {
                temp = sorted[j+1];
                sorted[j + 1] = sorted[j];
                sorted[j] = temp;
            }
            
        }
    }
    return sorted;
}

int median(int[] array)
{
    int result = 0;
    if (array.Length % 2 != 0) result = array[array.Length / 2];
    else
    {
        result = (array[array.Length / 2 - 1] + array[array.Length / 2]) / 2;
    }
    return result;
}

System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] mas = FillArray(N);
System.Console.WriteLine(string.Join(", ", mas));
int[] allStuff = {
                    maxMinIndex(mas)[0], mas[maxMinIndex(mas)[0]],
                    maxMinIndex(mas)[1], mas[maxMinIndex(mas)[1]],
                    average(mas), median(sortArray(mas))
                };
System.Console.WriteLine($"Мин индекс = {allStuff[0]}, значение = {allStuff[1]}, " +
                         $"Макс индекс = {allStuff[2]}, значение = {allStuff[3]}, " +
                         $"среднее = {allStuff[4]}, медиана = {allStuff[5]}");
System.Console.WriteLine(string.Join(", ", mas));
