// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] fillArrayDouble(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() + new Random().Next(-100,110),2);
    }
    return result;
}

int[] maxMinIndex(double[] array)
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
        if (array[i] > result[1]) result[1] = i;
        else if (array[i] < result[0]) result[0] = i;
    }
    return result;
}

double minMaxDiff(double[] array, int[] index)
{
    return array[index[1]]-array[index[0]];
}

System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = fillArrayDouble(N);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(
$"Разница между макисимальным {array[maxMinIndex(array)[1]]} и минимальным {array[maxMinIndex(array)[0]]} элементом массива равна {minMaxDiff(array, maxMinIndex(array))}");
